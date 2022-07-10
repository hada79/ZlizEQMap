using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using TheArtOfDev.HtmlRenderer.WinForms;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ZlizEQMap
{
	public partial class ZlizEQMapForm : Form
	{
		static Regex regExEnteredZone = new Regex(@"^\[.+\] You have entered (.+)\.$", RegexOptions.Compiled);
		static Regex regExLocation = new Regex(@"^\[.+\] Your Location is (.+), (.+), .+$", RegexOptions.Compiled);
		static Regex regExDirection = new Regex(@"^\[.+\] You think you are heading (.+)\.$", RegexOptions.Compiled);

		MapPoint playerLocation = null;
		MapPoint waypoint = null;
		bool locationIsWithinMap;
		Direction playerDirection = Direction.Unknown;
		ZoneData currentZoneData;
		bool locInZoneHasBeenRecorded = false;
		LogFileParser parser;
		DateTime lastCharacterChange = DateTime.Now.Subtract(TimeSpan.FromMinutes(1));
		List<ZoneData> zones;
		bool initialLoadCompleted = false;
		DateTime lastRecordedDirectionDateTime = DateTime.Now;
		DateTime lastRecordedLocationDateTime = DateTime.Now;
		Dictionary<PictureBox, ZoneData> subMapPictureBoxes = new Dictionary<PictureBox, ZoneData>();
		FileSystemWatcher watcher;
        Boolean forceLogReselection = false;
        int flowSubMapssubMapsTotalHeight = 1;

		public ZlizEQMapForm()
		{
			InitializeComponent();
			SetControlProperties();

			if (HandleSettings())
			{
				string logFileDirectory = GetLogFileDirectory();

				if (!Directory.Exists(logFileDirectory))
				{
					MessageBox.Show(String.Format("Log file directory '{0}' does not exist. Ensure the log file directory exists at this location.", logFileDirectory), "ZlizEQMap", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Environment.Exit(1);
				}

				Initialize();
			}
			else
				Environment.Exit(0);
		}

		private bool HandleSettings()
		{
			if (!Directory.Exists(Paths.SettingsFileDirectory))
				Directory.CreateDirectory(Paths.SettingsFileDirectory);

			if (!Settings.SettingsFileExists)
				return HandleFirstRun(true);
			else
			{
				Settings.LoadSettings();

				if (!Directory.Exists(Settings.GetEQDirectoryPath()))
					return HandleFirstRun(false);

				zones = ZoneDataFactory.GetAllZones(Settings.GetZoneDataSet());
				SetControlsFromSettings();
				SwitchZoneByShortName(Settings.LastSelectedZone);
				return true;
			}
		}

		private void Initialize()
		{
			SetupFileSystemWatcher();
			PopulateZoneComboBox();

			initialLoadCompleted = true;

			if (checkAutoSizeOnMapSwitch.Checked)
				AutoSizeForm();

			btnAutosize.Select();
		}

		private void SetupFileSystemWatcher()
		{
			string logFileDirectory = GetLogFileDirectory();

			if (watcher != null)
			{
				watcher.Dispose();
				watcher.EnableRaisingEvents = false;
				parser = null;
				timer1.Enabled = false;
			}

			watcher = new FileSystemWatcher();

			watcher.Path = logFileDirectory;
			watcher.Filter = "eqlog_*.txt";
			watcher.NotifyFilter = NotifyFilters.LastWrite;
			watcher.Changed += new FileSystemEventHandler(watcher_Changed);
			watcher.SynchronizingObject = this;
			watcher.EnableRaisingEvents = true;
		}

		private string GetLogFileDirectory()
		{
			string logFileDirectory = "";

			if (Settings.GetLogsInLogsDir() == SettingsLogsInLogsDir.LogsDir)
				logFileDirectory = Path.Combine(Settings.GetEQDirectoryPath(), "Logs");
			else if (Settings.GetLogsInLogsDir() == SettingsLogsInLogsDir.RootDir)
				logFileDirectory = Settings.GetEQDirectoryPath();

			return logFileDirectory;
		}

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            // Prevent spam from the FileSystemWatcher - a character change more than every 20 seconds is highly unlikely
            if (DateTime.Now > lastCharacterChange.AddSeconds(5) || forceLogReselection)
            {
                if ( parser == null 
                    || e.FullPath != parser.LogFilePath
                    )
				{
					parser = new LogFileParser(e.FullPath);
					SetFormTitle(currentZoneData.FullName);
					timer1.Enabled = true;
					lastCharacterChange = DateTime.Now;

                }
			}

            forceLogReselection = false;
        }

		private bool HandleFirstRun(bool initializeDefaultSettings)
		{
			FirstRun form = new FirstRun();
			form.ShowDialog();

			if (form.EQDirectoryValid)
			{
				if (initializeDefaultSettings)
					Settings.InitializeDefaultSettings();

				Settings.EQDirectoryPath1 = form.EQDirectory;
				Settings.LogsInLogsDir1 = form.LogsInLogsDir;
				Settings.ZoneDataSet1 = form.ZoneDataSet;
				Settings.SaveSettings();

				zones = ZoneDataFactory.GetAllZones(Settings.GetZoneDataSet());

				SwitchZoneByShortName(Settings.LastSelectedZone);

				return true;
			}
			else
				return false;
		}

		private void SetControlsFromSettings()
		{
			checkAutoSizeOnMapSwitch.Checked = Settings.CheckAutoSizeOnMapSwitch;
			checkGroupByContinent.Checked = Settings.CheckGroupByContinent;
			checkEnableDirection.Checked = Settings.CheckEnableDirection;
			checkLegend.Checked = Settings.CheckEnableLegend;
			sliderOpacity.Value = Settings.OpacityLevel;
			SetFormOpacity();
			checkAlwaysOnTop.Checked = Settings.AlwaysOnTop;
			SetAlwaysOnTop();
		}

		private void PopulateZoneComboBox()
		{
			comboZone.Items.Clear();

			if (!checkGroupByContinent.Checked)
			{
				foreach (ZoneData map in zones.Where(x => x.SubMapIndex == 1).OrderBy(x => x.FullName))
				{
					comboZone.Items.Add(map.FullName);
				}
			}
			else
			{
				List<string> continents = new List<string>();

				foreach (ZoneData map in zones.OrderBy(x => x.ContinentSortOrder))
				{
					if (!continents.Contains(map.Continent))
						continents.Add(map.Continent);
				}

				foreach (string continent in continents)
				{
					comboZone.Items.Add(String.Format("-------------------- {0} --------------------", continent));

					foreach (ZoneData map in zones.Where(x => x.Continent == continent && x.SubMapIndex == 1).OrderBy(x => x.FullName))
					{
						comboZone.Items.Add(map.FullName);
					}
				}
			}

			if (currentZoneData != null)
				comboZone.SelectedItem = currentZoneData.FullName;
		}

		private MapPoint GetMapImageLocationPoint(int x, int y)
		{
			Image image = Image.FromFile(currentZoneData.ImageFilePath);
			// Amount of coords per pixel of the map image, on the Y axis (vertical)
			float imageYCoordRatio = (float)currentZoneData.TotalY / (float)image.Size.Height;
			// Amount of coords per pixel of the map image, on the X axis (horizontal)
			float imageXCoordRatio = (float)currentZoneData.TotalX / (float)image.Size.Width;

			int newLocationXPixel = currentZoneData.ZeroLocation.X - (int)((float)x / imageXCoordRatio);
			int newLocationYPixel = currentZoneData.ZeroLocation.Y - (int)((float)y / imageYCoordRatio);

			if (PlayerLocationIsWithinMapImage(newLocationXPixel, newLocationYPixel, image.Size.Height, image.Size.Width))
			{
				MapPoint point = new MapPoint() { X = newLocationXPixel, Y = newLocationYPixel };
				return point;
			}
			else
				return null;
		}

		private void UpdatePlayerLocation(int x, int y)
		{
			locInZoneHasBeenRecorded = true;
			lastRecordedLocationDateTime = DateTime.Now;

			MapPoint point = GetMapImageLocationPoint(x, y);

			if (point != null)
			{
				this.playerLocation = point;
				locationIsWithinMap = true;
			}
			else
				locationIsWithinMap = false;

			picBox.Invalidate();
		}

		private void SwitchZoneByShortName(string zoneShortName)
		{
			ZoneData zone = ZoneDataFactory.FetchByShortZoneName(zones, zoneShortName);
            if (zone == null)
                zone = ZoneDataFactory.FetchByShortZoneName(zones, "POKNOWLEDGE"); // makeit default to something if something goes wrong with the "lastZoneName" value
            if (zone == null)//if still null
                zone = ZoneDataFactory.FetchByShortZoneName(zones, "ecommons"); // make it default to something else for p99 people maybe?
            SwitchZone(zone.FullName, 1);
		}

		private void SwitchZone(string zoneName, int subMapIndex)
		{
			locInZoneHasBeenRecorded = false;
			ZoneData zoneData = ZoneDataFactory.FetchByFullZoneName(this.zones, zoneName, subMapIndex);

			if (zoneData == null)
			{
				MessageBox.Show(String.Format("Unable to find zone '{0}' in Zone Data", zoneName), "ZlizEQMap", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SetFormTitle(zoneName);

			labelZoneName.Text = zoneName;

			this.waypoint = null;
			SetButtonWaypointText();
			picBox.Load(zoneData.ImageFilePath);

			PopulateSubMaps(zoneData);

			currentZoneData = zoneData;
			comboZone.SelectedItem = zoneName;

			labelLegend.Text = LegendTextFactory.GetLegendText(currentZoneData);

			PopulateConnectedZones();
			this.playerLocation = null;

			if (checkAutoSizeOnMapSwitch.Checked)
				AutoSizeForm();
			else
				PositionLabels();
		}

		private void SetFormTitle(string zoneName)
		{
			if (parser != null)
				this.Text = String.Format("{0} ({1}) - ZlizEQMap", zoneName, GetActiveCharacterName(parser.LogFilePath));
			else
				this.Text = String.Format("{0} - ZlizEQMap", zoneName);
		}

		private string GetActiveCharacterName(string logFilePath)
		{
			string logFileName = Path.GetFileNameWithoutExtension(logFilePath);

			int i = logFileName.IndexOf('_') + 1;
			int j = logFileName.LastIndexOf('_');

			return logFileName.Substring(i, j - i);
		}

		private void PopulateConnectedZones()
		{
			if (currentZoneData.ConnectedZones.Count > 0)
			{
				panelConnectedZones.Visible = true;
				panelConnectedZones.Controls.Clear();
				panelConnectedZones.Controls.Add(labelConnectedZones);
				panelConnectedZones.Text = "Connected Zones:";

				foreach (ZoneData zone in currentZoneData.ConnectedZones.OrderBy(x => x.FullName))
				{
					LinkLabel ll = new LinkLabel();
					ll.Text = zone.FullName;
					ll.AutoSize = true;
					ll.Name = zone.FullName;
					ll.LinkClicked += new LinkLabelLinkClickedEventHandler(ll_LinkClicked);

					this.panelConnectedZones.Controls.Add(ll);
				}
			}
			else
				panelConnectedZones.Visible = false;
		}

		void ll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SwitchZone((sender as LinkLabel).Text, 1);
		}

		private void PopulateSubMaps(ZoneData zoneData)
		{
			flowSubMaps.Controls.Clear();
			subMapPictureBoxes.Clear();
			flowSubMaps.Height = 1;
			flowSubMaps.Visible = false;
			var subZones = this.zones.Where(x => x.FullName == zoneData.FullName);
			int i = 0;

			if (subZones.Count() > 1)
			{
				foreach (ZoneData zone in subZones.OrderBy(x => x.SubMapIndex))
				{
					Color borderColor = Color.Transparent;

					if (zone.SubMapIndex == zoneData.SubMapIndex)
						borderColor = Color.MediumPurple;

					ZlizPanel panel = new ZlizPanel(borderColor);
					panel.Size = new System.Drawing.Size(102, 102);
					panel.Location = new Point(0, i++ * 101);

					ZlizPictureBox pb = new ZlizPictureBox();
					pb.SizeMode = PictureBoxSizeMode.StretchImage;
					pb.WaitOnLoad = true;
					pb.Load(zone.ImageFilePath);
					pb.Size = new System.Drawing.Size(100, 100);
					pb.Location = new Point(1, 1);
					pb.Click += new EventHandler(pb_Click);
					pb.MouseHover += new EventHandler(pb_MouseHover);
					pb.SubMapDescription = zone.SubMapDescription;

					panel.Controls.Add(pb);

					flowSubMaps.Controls.Add(panel);
					subMapPictureBoxes.Add(pb, zone);
				}

                flowSubMapssubMapsTotalHeight = i * 110;
                ReCalcFlowSubMapsHeight();
                flowSubMaps.Visible = true;
			}
		}

		void pb_Click(object sender, EventArgs e)
		{
			PictureBox pb = (sender as PictureBox);

			ZoneData zoneData = subMapPictureBoxes[pb];

			SwitchZone(zoneData.FullName, zoneData.SubMapIndex);
		}

		void pb_MouseHover(object sender, EventArgs e)
		{
			ZlizPictureBox pb = sender as ZlizPictureBox;

			if (pb.SubMapDescription != null)
			{
				ToolTip tt = new ToolTip() { InitialDelay = 200 };

				tt.SetToolTip(pb, pb.SubMapDescription);
			}
		}

		private void picBox_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Red, 2f);

			if (locInZoneHasBeenRecorded)
			{
				if (!locationIsWithinMap)
				{
					// Draw circle indicating that the location was the last successfully recorded (player is probably out of the bounds of the map now)
					int i = 7;

					if (playerLocation != null)
						e.Graphics.DrawEllipse(pen, playerLocation.X - i, playerLocation.Y - i, 2 * i, 2 * i);
					else
						e.Graphics.DrawEllipse(pen, 1, 1, 2 * i, 2 * i);
				}
				else
				{
					if (playerDirection == Direction.Unknown || !checkEnableDirection.Checked || lastRecordedLocationDateTime - lastRecordedDirectionDateTime > TimeSpan.FromMilliseconds(1500))
					{
						// Draw player location X
						int i = 4;
						e.Graphics.DrawLine(pen, new Point(playerLocation.X - i, playerLocation.Y - i), new Point(playerLocation.X + i, playerLocation.Y + i));
						e.Graphics.DrawLine(pen, new Point(playerLocation.X + i, playerLocation.Y - i), new Point(playerLocation.X - i, playerLocation.Y + i));
					}
					else if (lastRecordedLocationDateTime - lastRecordedDirectionDateTime <= TimeSpan.FromMilliseconds(1500))
					{
						// Draw arrow facing in player direction
						AdjustableArrowCap arrow = new AdjustableArrowCap(5, 4);
						pen.CustomEndCap = arrow;

						PointSet pointSet = GetDirectionLinePointSet();

						e.Graphics.DrawLine(pen, pointSet.Point1, pointSet.Point2);
					}
				}
			}

			if (waypoint != null)
			{
				int i = 4;

				e.Graphics.DrawEllipse(new Pen(Color.Blue, 2f), waypoint.X - i, waypoint.Y - i, 2 * i, 2 * i);
			}
		}

		private bool PlayerLocationIsWithinMapImage(int locationXPixel, int locationYPixel, int imageHeight, int imageWidth)
		{
			return (locationXPixel > 0 && locationYPixel > 0 && locationXPixel < imageWidth && locationYPixel < imageHeight);
		}

		private PointSet GetDirectionLinePointSet()
		{
			int i = 6;
			int j = 7;

			switch (playerDirection)
			{
				case Direction.North:
					return new PointSet() { Point1 = new Point(playerLocation.X, playerLocation.Y + j), Point2 = new Point(playerLocation.X, playerLocation.Y - j) };
				case Direction.NorthEast:
					return new PointSet() { Point1 = new Point(playerLocation.X - i, playerLocation.Y + i), Point2 = new Point(playerLocation.X + i, playerLocation.Y - i) };
				case Direction.East:
					return new PointSet() { Point1 = new Point(playerLocation.X - j, playerLocation.Y), Point2 = new Point(playerLocation.X + j, playerLocation.Y) };
				case Direction.SouthEast:
					return new PointSet() { Point1 = new Point(playerLocation.X - i, playerLocation.Y - i), Point2 = new Point(playerLocation.X + i, playerLocation.Y + i) };
				case Direction.South:
					return new PointSet() { Point1 = new Point(playerLocation.X, playerLocation.Y - j), Point2 = new Point(playerLocation.X, playerLocation.Y + j) };
				case Direction.SouthWest:
					return new PointSet() { Point1 = new Point(playerLocation.X + i, playerLocation.Y - i), Point2 = new Point(playerLocation.X - i, playerLocation.Y + i) };
				case Direction.West:
					return new PointSet() { Point1 = new Point(playerLocation.X + j, playerLocation.Y), Point2 = new Point(playerLocation.X - j, playerLocation.Y) };
				case Direction.NorthWest:
					return new PointSet() { Point1 = new Point(playerLocation.X + i, playerLocation.Y + i), Point2 = new Point(playerLocation.X - i, playerLocation.Y - i) };

				default:
					throw new Exception("Unhandled playerDirection");
			}
		}

		private void checkEnableDirection_CheckedChanged(object sender, EventArgs e)
		{
			picBox.Invalidate();
		}

		private void checkLegend_CheckedChanged(object sender, EventArgs e)
		{
			labelLegend.Visible = checkLegend.Checked;

			if (checkAutoSizeOnMapSwitch.Checked)
				AutoSizeForm();
		}

		private void checkGroupByContinent_CheckedChanged(object sender, EventArgs e)
		{
			if (initialLoadCompleted)
				PopulateZoneComboBox();
		}

		private void comboZone_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!comboZone.SelectedItem.ToString().StartsWith("-") && initialLoadCompleted)
				SwitchZone(comboZone.SelectedItem.ToString(), 1);
		}

		private void btnAutosize_Click(object sender, EventArgs e)
		{
			AutoSizeForm();
		}

		private void AutoSizeForm()
		{
			if (initialLoadCompleted)
			{
				PositionLabels();

				int width = 1000;
				if (picBox.Width + 60 > width)
					width = picBox.Width + 70;

				var subMaps = this.zones.Where(x => x.FullName == currentZoneData.FullName);

				if (subMaps.Count() > 1)
					width += flowSubMaps.Width;

				this.Width = width;

				int legendHeight = labelLegend.Height;

				if (!checkLegend.Checked)
					legendHeight = 10;

				int height = labelZoneName.Height + picBox.Height + legendHeight + 105;

				if (panelMain.VerticalScroll.Visible)
				{
					labelLegend.Width = labelLegend.Width - 30;
					flowSubMaps.Location = new Point(this.Width - 150, flowSubMaps.Location.Y);
				}

				Rectangle working = Screen.GetWorkingArea(this.picBox);
				if (height > working.Height - 100)
					height = working.Height - 100;

				this.Height = height;
				PositionLabels();
			}
		}

		private void PositionLabels()
		{
			panelConnectedZones.Location = new Point(picBox.Location.X, picBox.Location.Y + picBox.Height + 5);
			labelLegend.Location = new Point(picBox.Location.X, panelConnectedZones.Location.Y + 10);
		}

		private void ZlizEQMapForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			watcher.Dispose();

			Settings.CheckAutoSizeOnMapSwitch = checkAutoSizeOnMapSwitch.Checked;
			Settings.CheckEnableDirection = checkEnableDirection.Checked;
			Settings.CheckEnableLegend = checkLegend.Checked;
			Settings.CheckGroupByContinent = checkGroupByContinent.Checked;

			if (currentZoneData != null)
				Settings.LastSelectedZone = currentZoneData.ShortName;

			Settings.OpacityLevel = sliderOpacity.Value;
			Settings.AlwaysOnTop = checkAlwaysOnTop.Checked;

			Settings.SaveSettings();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Direction direction = Direction.Unknown;
			int? locx = null;
			int? locy = null;
			string zone = null;

			List<string> lines = parser.GetNewLines();
			lines.Reverse();

			foreach (string line in lines)
			{
				Match matchZone = regExEnteredZone.Match(line);

				if (zone == null && matchZone.Groups[1].Value != "an Arena (PvP) area" && matchZone.Success)
					zone = matchZone.Groups[1].Value;

				Match matchDirection = regExDirection.Match(line);

				if (direction == Direction.Unknown && matchDirection.Success)
					direction = (Direction)Enum.Parse(typeof(Direction), matchDirection.Groups[1].Value);

				if (zone != null || currentZoneData != null)
				{
					Match matchLocation = regExLocation.Match(line);

					if (locx == null && matchLocation.Success)
					{
						string locxString = matchLocation.Groups[2].Value;
						string locyString = matchLocation.Groups[1].Value;

						locxString = locxString.Substring(0, locxString.IndexOf('.'));
						locyString = locyString.Substring(0, locyString.IndexOf('.'));

						locx = Convert.ToInt32(locxString);
						locy = Convert.ToInt32(locyString);
					}
				}

				if (zone != null && direction != Direction.Unknown && locx != null)
					break;
			}

			if (!String.IsNullOrEmpty(zone))
				SwitchZone(zone, 1);

			if (direction != Direction.Unknown)
			{
				playerDirection = direction;
				lastRecordedDirectionDateTime = DateTime.Now;
			}

			if (locx.HasValue)
				UpdatePlayerLocation(Convert.ToInt32(locx.Value), Convert.ToInt32(locy.Value));
		}

        private void ReCalcFlowSubMapsHeight()
        {
            //so we don't hide icons offscren if map is taller than window
            flowSubMaps.Height = Math.Min(flowSubMapssubMapsTotalHeight, panelMain.Height); //check size of number of SubMaps vs main map height 
            flowSubMaps.Height = Math.Min(flowSubMaps.Height, this.Height); //so we don't hide icons offscren if map is taller than window
        }

		private void ZlizEQMapForm_SizeChanged(object sender, EventArgs e)
		{

            ReCalcFlowSubMapsHeight();

            labelLegend.MaximumSize = new Size(this.Width - 50, 1000000);
		}

		private void linkLabelWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(String.Format("{0}{1}", Settings.WikiRootURL, currentZoneData.FullName));
		}

		private void btnSettingsHelp_Click(object sender, EventArgs e)
		{
			SettingsHelp settingsHelp = new SettingsHelp();
			settingsHelp.OnEQDirSettingsChanged += new EventHandler(settingsHelp_OnEQDirSettingsChanged);

			settingsHelp.ShowDialog();
		}

		void settingsHelp_OnEQDirSettingsChanged(object sender, EventArgs e)
		{
			zones = ZoneDataFactory.GetAllZones(Settings.GetZoneDataSet());
			Initialize();
			SwitchZoneByShortName(currentZoneData.ShortName);
		}

		private void sliderOpacity_Scroll(object sender, EventArgs e)
		{
			SetFormOpacity();
		}

		private void SetFormOpacity()
		{
			this.Opacity = sliderOpacity.Value * 5 / 100f;
		}

		private void ZlizEQMapForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized && Settings.MinimizeToTray)
			{
				notifyIcon1.Visible = true;
				this.Hide();
			}
		}

		private void notifyIcon1_Click(object sender, EventArgs e)
		{
			this.Show();
			notifyIcon1.Visible = false;
			this.WindowState = FormWindowState.Normal;
		}

		private void checkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
		{
			SetAlwaysOnTop();
		}

		private void SetAlwaysOnTop()
		{
			this.TopMost = checkAlwaysOnTop.Checked;
		}

		private void btnSetWaypoint_Click(object sender, EventArgs e)
		{
			if (waypoint == null)
			{
				string[] items = txtWaypoint.Text.Split(',');

				if (items.Length == 2)
				{
					int y;
					int x;

					if (Int32.TryParse(items[0].Trim(), out y) && Int32.TryParse(items[1].Trim(), out x))
						this.waypoint = GetMapImageLocationPoint(x, y);
				}
			}
			else
				waypoint = null;

			picBox.Invalidate();
			SetButtonWaypointText();
		}

		private void SetButtonWaypointText()
		{
			if (waypoint == null)
				btnSetWaypoint.Text = "Set WP";
			else
				btnSetWaypoint.Text = "Clear";
		}

        private void textBoxCharName_TextChanged(object sender, EventArgs e)
        {
            String charNameFilter = "";
            String assembledLogNamefilter = "";

            charNameFilter = textBoxCharName.Text;
            if (charNameFilter == "")
            {
                assembledLogNamefilter = String.Format("eqlog_*.txt");
            }
            else
            {
                assembledLogNamefilter = String.Format("eqlog_{0}.txt", charNameFilter);
            }

            watcher.Filter = assembledLogNamefilter;
            forceLogReselection = true;
        }
    }

    public class MapPoint
	{
		public int Y { get; set; }
		public int X { get; set; }
	}

	public class PointSet
	{
		public Point Point1 { get; set; }
		public Point Point2 { get; set; }
	}
}
