using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ZlizEQMap
{
	public partial class FirstRun : Form
	{
		public bool EQDirectoryValid { get; set; }
		public string EQDirectory { get; set; }
		public SettingsLogsInLogsDir LogsInLogsDir { get; set; }
		public string ZoneDataSet { get; set; }

		public FirstRun()
		{
			InitializeComponent();
			EQDirectoryValid = false;
			PopulateZoneDataSetCombobox();
		}

		private void PopulateZoneDataSetCombobox()
		{
			List<string> zoneDataSets = ZoneDataFactory.GetZoneDataSets();

			foreach (string set in zoneDataSets)
			{
				comboZoneData.Items.Add(set);
			}
		}

		private void txtEQDirectory_TextChanged(object sender, EventArgs e)
		{
			SetOKButtonEnabled();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				txtEQDirectory.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnEnableLogging_Click(object sender, EventArgs e)
		{
			string eqClientIniFilePath = Path.Combine(txtEQDirectory.Text, "eqclient.ini");

			if (ValidateEverQuestDirectory(eqClientIniFilePath))
			{
				List<string> lines = new List<string>();
				bool loggingModifed = false;
				string contents = "";

				using (FileStream fs = File.OpenRead(eqClientIniFilePath))
				{
					using (TextReader tr = new StreamReader(fs))
					{
						contents = tr.ReadToEnd();

						if (contents.ToLower().Contains("log=true"))
							labelLogStatus.Text = "Logging is already enabled.";
						else if (contents.ToLower().Contains("log=false"))
						{
							contents = Regex.Replace(contents, "log=false", "Log=TRUE", RegexOptions.IgnoreCase | RegexOptions.Multiline);
							loggingModifed = true;
						}
						else
						{
							contents += Environment.NewLine + "Log=TRUE";
							loggingModifed = true;
						}
					}
				}

				if (loggingModifed)
				{
					using (FileStream fs = File.OpenWrite(eqClientIniFilePath))
					{
						using (TextWriter tw = new StreamWriter(fs))
						{
							tw.Write(contents);

							labelLogStatus.Text = "Logging is now enabled.";
						}
					}
				}
			}
		}

		private bool ValidateEverQuestDirectory(string eqClientIniFilePath)
		{
			if (!File.Exists(eqClientIniFilePath))
			{
				MessageBox.Show(String.Format("eqclient.ini file was not found in the following directory:{0}{0}{1}{0}{0}Are you sure you chose your EverQuest directory?", Environment.NewLine, txtEQDirectory.Text), "ZlizEQMap", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string eqClientIniFilePath = Path.Combine(txtEQDirectory.Text, "eqclient.ini");

			if (ValidateEverQuestDirectory(eqClientIniFilePath))
			{
				EQDirectoryValid = true;
				EQDirectory = txtEQDirectory.Text;
				LogsInLogsDir = radioLogsLogs.Checked ? SettingsLogsInLogsDir.LogsDir : SettingsLogsInLogsDir.RootDir;
				ZoneDataSet = comboZoneData.Text;
				this.Close();
			}
		}

		private void comboZoneData_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetOKButtonEnabled();
		}

		private void SetOKButtonEnabled()
		{
			btnOK.Enabled = btnEnableLogging.Enabled = Directory.Exists(txtEQDirectory.Text) && comboZoneData.Text.Length > 0;
		}
	}
}
