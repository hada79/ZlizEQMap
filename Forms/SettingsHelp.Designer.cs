namespace ZlizEQMap
{
	partial class SettingsHelp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsHelp));
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioProfile2 = new System.Windows.Forms.RadioButton();
			this.radioProfile1 = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.comboZoneData2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEQDirectory2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnBrowse2 = new System.Windows.Forms.Button();
			this.radioLogsRoot2 = new System.Windows.Forms.RadioButton();
			this.radioLogsLogs2 = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboZoneData1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEQDirectory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.radioLogsRoot = new System.Windows.Forms.RadioButton();
			this.radioLogsLogs = new System.Windows.Forms.RadioButton();
			this.labelSettingsSaved = new System.Windows.Forms.Label();
			this.checkMinimizeToTray = new System.Windows.Forms.CheckBox();
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtWikiRoot = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.linkLabelReadme = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelVersion = new System.Windows.Forms.Label();
			this.linkLabelZlizUI = new System.Windows.Forms.LinkLabel();
			this.linkLabelZlizEQCom = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.label12 = new System.Windows.Forms.Label();
			this.txtLegendFontSize = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(256, 677);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtLegendFontSize);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.radioProfile2);
			this.groupBox1.Controls.Add(this.radioProfile1);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.labelSettingsSaved);
			this.groupBox1.Controls.Add(this.checkMinimizeToTray);
			this.groupBox1.Controls.Add(this.btnSaveSettings);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtWikiRoot);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(563, 419);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// radioProfile2
			// 
			this.radioProfile2.AutoSize = true;
			this.radioProfile2.Location = new System.Drawing.Point(446, 222);
			this.radioProfile2.Name = "radioProfile2";
			this.radioProfile2.Size = new System.Drawing.Size(95, 17);
			this.radioProfile2.TabIndex = 13;
			this.radioProfile2.Text = "Profile 2 active";
			this.radioProfile2.UseVisualStyleBackColor = true;
			this.radioProfile2.CheckedChanged += new System.EventHandler(this.radioProfile2_CheckedChanged);
			// 
			// radioProfile1
			// 
			this.radioProfile1.AutoSize = true;
			this.radioProfile1.Checked = true;
			this.radioProfile1.Location = new System.Drawing.Point(446, 82);
			this.radioProfile1.Name = "radioProfile1";
			this.radioProfile1.Size = new System.Drawing.Size(95, 17);
			this.radioProfile1.TabIndex = 12;
			this.radioProfile1.TabStop = true;
			this.radioProfile1.Text = "Profile 1 active";
			this.radioProfile1.UseVisualStyleBackColor = true;
			this.radioProfile1.CheckedChanged += new System.EventHandler(this.radioProfile1_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.comboZoneData2);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.txtEQDirectory2);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.btnBrowse2);
			this.groupBox5.Controls.Add(this.radioLogsRoot2);
			this.groupBox5.Controls.Add(this.radioLogsLogs2);
			this.groupBox5.Location = new System.Drawing.Point(16, 159);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(424, 134);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Profile 2";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.ForeColor = System.Drawing.Color.DarkRed;
			this.label11.Location = new System.Drawing.Point(13, 107);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(401, 15);
			this.label11.TabIndex = 15;
			this.label11.Text = "Tip: For Project1999, choose \'\\Logs directory\'. For EQMac, choose \'Root directory" +
    "\'.";
			// 
			// comboZoneData2
			// 
			this.comboZoneData2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboZoneData2.FormattingEnabled = true;
			this.comboZoneData2.Location = new System.Drawing.Point(94, 59);
			this.comboZoneData2.Name = "comboZoneData2";
			this.comboZoneData2.Size = new System.Drawing.Size(139, 21);
			this.comboZoneData2.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "EverQuest Directory:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Zone Dataset:";
			// 
			// txtEQDirectory2
			// 
			this.txtEQDirectory2.Location = new System.Drawing.Point(13, 33);
			this.txtEQDirectory2.Name = "txtEQDirectory2";
			this.txtEQDirectory2.Size = new System.Drawing.Size(324, 20);
			this.txtEQDirectory2.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Log files location:";
			// 
			// btnBrowse2
			// 
			this.btnBrowse2.Location = new System.Drawing.Point(343, 31);
			this.btnBrowse2.Name = "btnBrowse2";
			this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse2.TabIndex = 6;
			this.btnBrowse2.Text = "Browse...";
			this.btnBrowse2.UseVisualStyleBackColor = true;
			this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
			// 
			// radioLogsRoot2
			// 
			this.radioLogsRoot2.AutoSize = true;
			this.radioLogsRoot2.Location = new System.Drawing.Point(210, 87);
			this.radioLogsRoot2.Name = "radioLogsRoot2";
			this.radioLogsRoot2.Size = new System.Drawing.Size(91, 17);
			this.radioLogsRoot2.TabIndex = 8;
			this.radioLogsRoot2.Text = "Root directory";
			this.radioLogsRoot2.UseVisualStyleBackColor = true;
			// 
			// radioLogsLogs2
			// 
			this.radioLogsLogs2.AutoSize = true;
			this.radioLogsLogs2.Checked = true;
			this.radioLogsLogs2.Location = new System.Drawing.Point(108, 87);
			this.radioLogsLogs2.Name = "radioLogsLogs2";
			this.radioLogsLogs2.Size = new System.Drawing.Size(96, 17);
			this.radioLogsLogs2.TabIndex = 8;
			this.radioLogsLogs2.TabStop = true;
			this.radioLogsLogs2.Text = "\\Logs directory";
			this.radioLogsLogs2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.comboZoneData1);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.txtEQDirectory);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.btnBrowse);
			this.groupBox4.Controls.Add(this.radioLogsRoot);
			this.groupBox4.Controls.Add(this.radioLogsLogs);
			this.groupBox4.Location = new System.Drawing.Point(16, 19);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(424, 134);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Profile 1";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.DarkRed;
			this.label10.Location = new System.Drawing.Point(13, 107);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(401, 15);
			this.label10.TabIndex = 15;
			this.label10.Text = "Tip: For Project1999, choose \'\\Logs directory\'. For EQMac, choose \'Root directory" +
    "\'.";
			// 
			// comboZoneData1
			// 
			this.comboZoneData1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboZoneData1.FormattingEnabled = true;
			this.comboZoneData1.Location = new System.Drawing.Point(94, 59);
			this.comboZoneData1.Name = "comboZoneData1";
			this.comboZoneData1.Size = new System.Drawing.Size(139, 21);
			this.comboZoneData1.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Zone Dataset:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "EverQuest Directory:";
			// 
			// txtEQDirectory
			// 
			this.txtEQDirectory.Location = new System.Drawing.Point(13, 33);
			this.txtEQDirectory.Name = "txtEQDirectory";
			this.txtEQDirectory.Size = new System.Drawing.Size(324, 20);
			this.txtEQDirectory.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Log files location:";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(343, 31);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// radioLogsRoot
			// 
			this.radioLogsRoot.AutoSize = true;
			this.radioLogsRoot.Location = new System.Drawing.Point(210, 87);
			this.radioLogsRoot.Name = "radioLogsRoot";
			this.radioLogsRoot.Size = new System.Drawing.Size(91, 17);
			this.radioLogsRoot.TabIndex = 4;
			this.radioLogsRoot.Text = "Root directory";
			this.radioLogsRoot.UseVisualStyleBackColor = true;
			// 
			// radioLogsLogs
			// 
			this.radioLogsLogs.AutoSize = true;
			this.radioLogsLogs.Checked = true;
			this.radioLogsLogs.Location = new System.Drawing.Point(108, 87);
			this.radioLogsLogs.Name = "radioLogsLogs";
			this.radioLogsLogs.Size = new System.Drawing.Size(96, 17);
			this.radioLogsLogs.TabIndex = 4;
			this.radioLogsLogs.TabStop = true;
			this.radioLogsLogs.Text = "\\Logs directory";
			this.radioLogsLogs.UseVisualStyleBackColor = true;
			// 
			// labelSettingsSaved
			// 
			this.labelSettingsSaved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSettingsSaved.AutoSize = true;
			this.labelSettingsSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSettingsSaved.ForeColor = System.Drawing.Color.DarkRed;
			this.labelSettingsSaved.Location = new System.Drawing.Point(325, 395);
			this.labelSettingsSaved.Name = "labelSettingsSaved";
			this.labelSettingsSaved.Size = new System.Drawing.Size(95, 13);
			this.labelSettingsSaved.TabIndex = 8;
			this.labelSettingsSaved.Text = "Settings saved.";
			this.labelSettingsSaved.Visible = false;
			// 
			// checkMinimizeToTray
			// 
			this.checkMinimizeToTray.AutoSize = true;
			this.checkMinimizeToTray.Location = new System.Drawing.Point(111, 334);
			this.checkMinimizeToTray.Name = "checkMinimizeToTray";
			this.checkMinimizeToTray.Size = new System.Drawing.Size(187, 17);
			this.checkMinimizeToTray.TabIndex = 10;
			this.checkMinimizeToTray.Text = "Minimize application to system tray";
			this.checkMinimizeToTray.UseVisualStyleBackColor = true;
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSaveSettings.Location = new System.Drawing.Point(244, 390);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
			this.btnSaveSettings.TabIndex = 11;
			this.btnSaveSettings.Text = "Save";
			this.btnSaveSettings.UseVisualStyleBackColor = true;
			this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 311);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Wiki Root URL:";
			// 
			// txtWikiRoot
			// 
			this.txtWikiRoot.Location = new System.Drawing.Point(111, 308);
			this.txtWikiRoot.Name = "txtWikiRoot";
			this.txtWikiRoot.Size = new System.Drawing.Size(329, 20);
			this.txtWikiRoot.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.linkLabelReadme);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 437);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(563, 74);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Help";
			// 
			// linkLabelReadme
			// 
			this.linkLabelReadme.AutoSize = true;
			this.linkLabelReadme.Location = new System.Drawing.Point(10, 48);
			this.linkLabelReadme.Name = "linkLabelReadme";
			this.linkLabelReadme.Size = new System.Drawing.Size(249, 13);
			this.linkLabelReadme.TabIndex = 14;
			this.linkLabelReadme.TabStop = true;
			this.linkLabelReadme.Text = "http://www.zlizeq.com/ZlizEQ_Projects-ZlizEQMap";
			this.linkLabelReadme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReadme_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "The help document for the program is located here:";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.labelVersion);
			this.groupBox3.Controls.Add(this.linkLabelZlizUI);
			this.groupBox3.Controls.Add(this.linkLabelZlizEQCom);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(12, 517);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(563, 150);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "About";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(13, 27);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(86, 13);
			this.labelVersion.TabIndex = 4;
			this.labelVersion.Text = "Program version:";
			// 
			// linkLabelZlizUI
			// 
			this.linkLabelZlizUI.AutoSize = true;
			this.linkLabelZlizUI.Location = new System.Drawing.Point(13, 124);
			this.linkLabelZlizUI.Name = "linkLabelZlizUI";
			this.linkLabelZlizUI.Size = new System.Drawing.Size(163, 13);
			this.linkLabelZlizUI.TabIndex = 16;
			this.linkLabelZlizUI.TabStop = true;
			this.linkLabelZlizUI.Text = "ZlizUI, a minimalist UI for Live EQ";
			this.linkLabelZlizUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelZlizUI_LinkClicked);
			// 
			// linkLabelZlizEQCom
			// 
			this.linkLabelZlizEQCom.AutoSize = true;
			this.linkLabelZlizEQCom.Location = new System.Drawing.Point(13, 97);
			this.linkLabelZlizEQCom.Name = "linkLabelZlizEQCom";
			this.linkLabelZlizEQCom.Size = new System.Drawing.Size(230, 13);
			this.linkLabelZlizEQCom.TabIndex = 15;
			this.linkLabelZlizEQCom.TabStop = true;
			this.linkLabelZlizEQCom.Text = "Zliz\'s Everquest Compendium - www.zlizeq.com";
			this.linkLabelZlizEQCom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelZlizEQCom_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(378, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "ZlizEQMap was developed by Zliz the Iksar Monk of Project1999 (Blue server).\r\nChe" +
    "ck out some of my other projects:";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Select your EverQuest directory path (not the log directory)";
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(16, 360);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 13);
			this.label12.TabIndex = 14;
			this.label12.Text = "Legend font size:";
			// 
			// txtLegendFontSize
			// 
			this.txtLegendFontSize.Location = new System.Drawing.Point(111, 357);
			this.txtLegendFontSize.Name = "txtLegendFontSize";
			this.txtLegendFontSize.Size = new System.Drawing.Size(42, 20);
			this.txtLegendFontSize.TabIndex = 15;
			// 
			// SettingsHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(587, 712);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsHelp";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings, Help & About ZlizEQMap";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.LinkLabel linkLabelReadme;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.LinkLabel linkLabelZlizEQCom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabelZlizUI;
		private System.Windows.Forms.TextBox txtEQDirectory;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtWikiRoot;
		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.CheckBox checkMinimizeToTray;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioLogsRoot;
		private System.Windows.Forms.RadioButton radioLogsLogs;
		private System.Windows.Forms.Label labelSettingsSaved;
		private System.Windows.Forms.RadioButton radioProfile2;
		private System.Windows.Forms.RadioButton radioProfile1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEQDirectory2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnBrowse2;
		private System.Windows.Forms.RadioButton radioLogsRoot2;
		private System.Windows.Forms.RadioButton radioLogsLogs2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboZoneData1;
		private System.Windows.Forms.ComboBox comboZoneData2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtLegendFontSize;
	}
}