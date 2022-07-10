using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ZlizEQMap
{
	public partial class SettingsHelp : Form
	{
		public event EventHandler OnEQDirSettingsChanged;

		private string version = "7";

		public SettingsHelp()
		{
			InitializeComponent();
			radioProfile1_CheckedChanged(null, null);
			labelVersion.Text = String.Format("Program version: {0}", version);
			PopulateSettings();
		}

		private void PopulateSettings()
		{
			txtEQDirectory.Text = Settings.EQDirectoryPath1;
			txtWikiRoot.Text = Settings.WikiRootURL;
			checkMinimizeToTray.Checked = Settings.MinimizeToTray;
			txtLegendFontSize.Text = Settings.LegendFontSize.ToString();
			radioLogsLogs.Checked = Settings.LogsInLogsDir1 == SettingsLogsInLogsDir.LogsDir;
			radioLogsRoot.Checked = Settings.LogsInLogsDir1 == SettingsLogsInLogsDir.RootDir;
			txtEQDirectory2.Text = Settings.EQDirectoryPath2;
			radioLogsLogs2.Checked = Settings.LogsInLogsDir2 == SettingsLogsInLogsDir.LogsDir;
			radioLogsRoot2.Checked = Settings.LogsInLogsDir2 == SettingsLogsInLogsDir.RootDir;

			if (Settings.ActiveProfileIndex == 1)
				radioProfile1.Checked = true;
			else
				radioProfile2.Checked = true;

			PopulateZoneDataSetCombobox();
			comboZoneData1.Text = Settings.ZoneDataSet1;
			comboZoneData2.Text = Settings.ZoneDataSet2;
		}

		private void PopulateZoneDataSetCombobox()
		{
			List<string> zoneDataSets = ZoneDataFactory.GetZoneDataSets();

			foreach (string set in zoneDataSets)
			{
				comboZoneData1.Items.Add(set);
				comboZoneData2.Items.Add(set);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void linkLabelReadme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.zlizeq.com/ZlizEQ_Projects-ZlizEQMap");
		}

		private void linkLabelZlizEQCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.zlizeq.com");
		}

		private void linkLabelZlizUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.eqinterface.com/downloads/fileinfo.php?id=6417");
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				txtEQDirectory.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnBrowse2_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				txtEQDirectory2.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnSaveSettings_Click(object sender, EventArgs e)
		{
			if (!ValidateSave())
				return;

			string previousEQDir = Settings.EQDirectoryPath1;
			SettingsLogsInLogsDir previousLogsInLogsDir = Settings.LogsInLogsDir1;
			int previousActiveProfileIndex = Settings.ActiveProfileIndex;
			int previousLegendFontSize = Settings.LegendFontSize;

			Settings.EQDirectoryPath1 = txtEQDirectory.Text;
			Settings.EQDirectoryPath2 = txtEQDirectory2.Text;
			Settings.LogsInLogsDir1 = radioLogsLogs.Checked ? SettingsLogsInLogsDir.LogsDir : SettingsLogsInLogsDir.RootDir;
			Settings.LogsInLogsDir2 = radioLogsLogs2.Checked ? SettingsLogsInLogsDir.LogsDir : SettingsLogsInLogsDir.RootDir;
			Settings.ActiveProfileIndex = radioProfile1.Checked ? 1 : 2;
			Settings.WikiRootURL = txtWikiRoot.Text;
			Settings.MinimizeToTray = checkMinimizeToTray.Checked;
			Settings.LegendFontSize = Convert.ToInt32(txtLegendFontSize.Text);
			Settings.ZoneDataSet1 = comboZoneData1.Text;
			Settings.ZoneDataSet2 = comboZoneData2.Text;

			Settings.SaveSettings();
			labelSettingsSaved.Visible = true;

			if (OnEQDirSettingsChanged != null &&
				(previousEQDir != Settings.EQDirectoryPath1 || previousLogsInLogsDir != Settings.LogsInLogsDir1 || previousActiveProfileIndex != Settings.ActiveProfileIndex
				|| previousLegendFontSize != Settings.LegendFontSize))
				OnEQDirSettingsChanged(this, null);
		}

		private bool ValidateSave()
		{
			StringBuilder errors = new StringBuilder();

			if (txtEQDirectory.Text.Length > 0 || radioProfile1.Checked)
			{
				if (!Directory.Exists(txtEQDirectory.Text))
					errors.AppendLine("Invalid EQ directory for Profile 1");

				if (comboZoneData1.Text.Length == 0)
					errors.AppendLine("Choose a zone dataset for Profile 1");
			}

			if (txtEQDirectory2.Text.Length > 0 || radioProfile2.Checked)
			{
				if (!Directory.Exists(txtEQDirectory2.Text))
					errors.AppendLine("Invalid EQ directory for Profile 2");

				if (comboZoneData2.Text.Length == 0)
					errors.AppendLine("Choose a zone dataset for Profile 2");
			}

			if (errors.Length > 0)
			{
				MessageBox.Show(errors.ToString(), "ZlizEQMap", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void radioProfile1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioProfile1.Checked)
				radioProfile1.Font = new Font(radioProfile1.Font, FontStyle.Bold);
			else
				radioProfile1.Font = new Font(radioProfile1.Font, FontStyle.Regular);
		}

		private void radioProfile2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioProfile2.Checked)
				radioProfile2.Font = new Font(radioProfile2.Font, FontStyle.Bold);
			else
				radioProfile2.Font = new Font(radioProfile2.Font, FontStyle.Regular);
		}
	}
}
