using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZlizEQMap
{
	public enum SettingsLogsInLogsDir
	{
		Undefined = 0,
		LogsDir = 1,
		RootDir = 2
	}

	public static class Settings
	{
		public static string EQDirectoryPath1 { get; set; }
		public static string EQDirectoryPath2 { get; set; }
		public static SettingsLogsInLogsDir LogsInLogsDir1 { get; set; }
		public static SettingsLogsInLogsDir LogsInLogsDir2 { get; set; }
		public static string ZoneDataSet1 { get; set; }
		public static string ZoneDataSet2 { get; set; }
		public static int ActiveProfileIndex { get; set; }

		public static bool CheckAutoSizeOnMapSwitch { get; set; }
		public static bool CheckGroupByContinent { get; set; }
		public static bool CheckEnableDirection { get; set; }
		public static bool CheckEnableLegend { get; set; }
		public static string LastSelectedZone { get; set; }
		public static string WikiRootURL { get; set; }
		public static int OpacityLevel { get; set; }
		public static bool MinimizeToTray { get; set; }
		public static bool AlwaysOnTop { get; set; }
		public static int LegendFontSize { get; set; }

		public static string GetEQDirectoryPath()
		{
			if (ActiveProfileIndex == 1)
				return EQDirectoryPath1;
			else
				return EQDirectoryPath2;
		}

		public static SettingsLogsInLogsDir GetLogsInLogsDir()
		{
			if (ActiveProfileIndex == 1)
				return LogsInLogsDir1;
			else
				return LogsInLogsDir2;
		}

		public static string GetZoneDataSet()
		{
			if (ActiveProfileIndex == 1)
				return ZoneDataSet1;
			else
				return ZoneDataSet2;
		}

		public static bool SettingsFileExists
		{
			get { return File.Exists(Paths.SettingsFilePath); }
		}

		public static void InitializeDefaultSettings()
		{
			CheckAutoSizeOnMapSwitch = true;
			CheckGroupByContinent = true;
			CheckEnableDirection = true;
			CheckEnableLegend = true;
			LastSelectedZone = "ecommons";
			WikiRootURL = "http://wiki.project1999.com/";
			OpacityLevel = 20;
			MinimizeToTray = false;
			AlwaysOnTop = false;
			ActiveProfileIndex = 1;
			LogsInLogsDir2 = SettingsLogsInLogsDir.RootDir;
			LegendFontSize = 10;
		}

		public static void LoadSettings()
		{
			using (FileStream fs = File.OpenRead(Paths.SettingsFilePath))
			{
				using (TextReader tr = new StreamReader(fs))
				{
					string line = "";

					while ((line = tr.ReadLine()) != null)
					{
						string key = line.Split('=')[0];
						string value = line.Split('=')[1];

						if (key == "EQDirectoryPath1")
							EQDirectoryPath1 = value;
						else if (key == "EQDirectoryPath2")
							EQDirectoryPath2 = value;
						else if (key == "LogsInLogsDir1")
							LogsInLogsDir1 = (SettingsLogsInLogsDir)Convert.ToInt32(value);
						else if (key == "LogsInLogsDir2")
							LogsInLogsDir2 = (SettingsLogsInLogsDir)Convert.ToInt32(value);
						else if (key == "ZoneDataSet1")
							ZoneDataSet1 = value;
						else if (key == "ZoneDataSet2")
							ZoneDataSet2 = value;
						else if (key == "ActiveProfileIndex")
							ActiveProfileIndex = Convert.ToInt32(value);
						else if (key == "CheckAutoSizeOnMapSwitch")
							CheckAutoSizeOnMapSwitch = Convert.ToBoolean(value);
						else if (key == "CheckGroupByContinent")
							CheckGroupByContinent = Convert.ToBoolean(value);
						else if (key == "CheckEnableDirection")
							CheckEnableDirection = Convert.ToBoolean(value);
						else if (key == "CheckEnableLegend")
							CheckEnableLegend = Convert.ToBoolean(value);
						else if (key == "LastSelectedZone")
							LastSelectedZone = value;
						else if (key == "WikiRootURL")
							WikiRootURL = value;
						else if (key == "OpacityLevel")
						{
							int level = Convert.ToInt32(value);

							if (level < 2 || level > 20)
								level = 20;

							OpacityLevel = level;
						}
						else if (key == "MinimizeToTray")
							MinimizeToTray = Convert.ToBoolean(value);
						else if (key == "AlwaysOnTop")
							AlwaysOnTop = Convert.ToBoolean(value);
						else if (key == "LegendFontSize")
							LegendFontSize = Convert.ToInt32(value);
					}
				}
			}

			// Backward compatibility when adding new settings

			if (LegendFontSize == 0)
				LegendFontSize = 10;
		}
		
		public static void SaveSettings()
		{
			using (FileStream fs = File.Create(Paths.SettingsFilePath))
			{
				using (TextWriter tw = new StreamWriter(fs))
				{
					WriteSetting(tw, "EQDirectoryPath1", EQDirectoryPath1);
					WriteSetting(tw, "EQDirectoryPath2", EQDirectoryPath2);
					WriteSetting(tw, "LogsInLogsDir1", Convert.ToInt32(LogsInLogsDir1).ToString());
					WriteSetting(tw, "LogsInLogsDir2", Convert.ToInt32(LogsInLogsDir2).ToString());
					WriteSetting(tw, "ZoneDataSet1", ZoneDataSet1);
					WriteSetting(tw, "ZoneDataSet2", ZoneDataSet2);
					WriteSetting(tw, "ActiveProfileIndex", ActiveProfileIndex.ToString());
					WriteSetting(tw, "CheckAutoSizeOnMapSwitch", CheckAutoSizeOnMapSwitch.ToString());
					WriteSetting(tw, "CheckGroupByContinent", CheckGroupByContinent.ToString());
					WriteSetting(tw, "CheckEnableDirection", CheckEnableDirection.ToString());
					WriteSetting(tw, "CheckEnableLegend", CheckEnableLegend.ToString());
					WriteSetting(tw, "LastSelectedZone", LastSelectedZone);
					WriteSetting(tw, "WikiRootURL", WikiRootURL);
					WriteSetting(tw, "OpacityLevel", OpacityLevel.ToString());
					WriteSetting(tw, "MinimizeToTray", MinimizeToTray.ToString());
					WriteSetting(tw, "AlwaysOnTop", AlwaysOnTop.ToString());
					WriteSetting(tw, "LegendFontSize", LegendFontSize.ToString());
				}
			}
		}

		private static void WriteSetting(TextWriter tw, string key, string value)
		{
			tw.WriteLine(String.Format("{0}={1}", key, value));
		}
	}
}
