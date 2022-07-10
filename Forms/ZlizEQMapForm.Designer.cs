namespace ZlizEQMap
{
	partial class ZlizEQMapForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZlizEQMapForm));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.checkLegend = new System.Windows.Forms.CheckBox();
            this.checkEnableDirection = new System.Windows.Forms.CheckBox();
            this.labelLegend = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.comboZone = new System.Windows.Forms.ComboBox();
            this.checkGroupByContinent = new System.Windows.Forms.CheckBox();
            this.btnAutosize = new System.Windows.Forms.Button();
            this.checkAutoSizeOnMapSwitch = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelWiki = new System.Windows.Forms.LinkLabel();
            this.sliderOpacity = new System.Windows.Forms.TrackBar();
            this.checkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.btnSetWaypoint = new System.Windows.Forms.Button();
            this.textBoxCharName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelConnectedZones = new System.Windows.Forms.FlowLayoutPanel();
            this.labelConnectedZones = new System.Windows.Forms.Label();
            this.flowSubMaps = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSettingsHelp = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtWaypoint = new System.Windows.Forms.TextBox();
            this.labelCharName = new System.Windows.Forms.Label();
            this.labelZoneName = new ZlizEQMap.ZlizLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOpacity)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelConnectedZones.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(3, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 50);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.WaitOnLoad = true;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            // 
            // checkLegend
            // 
            this.checkLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkLegend.AutoSize = true;
            this.checkLegend.Checked = true;
            this.checkLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLegend.Location = new System.Drawing.Point(754, 836);
            this.checkLegend.Name = "checkLegend";
            this.checkLegend.Size = new System.Drawing.Size(61, 17);
            this.checkLegend.TabIndex = 11;
            this.checkLegend.Text = "Legend";
            this.checkLegend.UseVisualStyleBackColor = true;
            this.checkLegend.CheckedChanged += new System.EventHandler(this.checkLegend_CheckedChanged);
            // 
            // checkEnableDirection
            // 
            this.checkEnableDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEnableDirection.AutoSize = true;
            this.checkEnableDirection.Checked = true;
            this.checkEnableDirection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEnableDirection.Location = new System.Drawing.Point(680, 836);
            this.checkEnableDirection.Name = "checkEnableDirection";
            this.checkEnableDirection.Size = new System.Drawing.Size(68, 17);
            this.checkEnableDirection.TabIndex = 10;
            this.checkEnableDirection.Text = "Direction";
            this.checkEnableDirection.UseVisualStyleBackColor = true;
            this.checkEnableDirection.CheckedChanged += new System.EventHandler(this.checkEnableDirection_CheckedChanged);
            // 
            // labelLegend
            // 
            this.labelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLegend.BackColor = System.Drawing.SystemColors.Window;
            this.labelLegend.BaseStylesheet = null;
            this.labelLegend.Location = new System.Drawing.Point(3, 431);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(74, 20);
            this.labelLegend.TabIndex = 13;
            this.labelLegend.Text = "htmlLabel1";
            // 
            // comboZone
            // 
            this.comboZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZone.FormattingEnabled = true;
            this.comboZone.Location = new System.Drawing.Point(622, 13);
            this.comboZone.Name = "comboZone";
            this.comboZone.Size = new System.Drawing.Size(298, 21);
            this.comboZone.TabIndex = 2;
            this.comboZone.SelectedIndexChanged += new System.EventHandler(this.comboZone_SelectedIndexChanged);
            // 
            // checkGroupByContinent
            // 
            this.checkGroupByContinent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkGroupByContinent.AutoSize = true;
            this.checkGroupByContinent.Checked = true;
            this.checkGroupByContinent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGroupByContinent.Location = new System.Drawing.Point(797, 40);
            this.checkGroupByContinent.Name = "checkGroupByContinent";
            this.checkGroupByContinent.Size = new System.Drawing.Size(120, 17);
            this.checkGroupByContinent.TabIndex = 5;
            this.checkGroupByContinent.Text = "Group by Continent";
            this.checkGroupByContinent.UseVisualStyleBackColor = true;
            this.checkGroupByContinent.CheckedChanged += new System.EventHandler(this.checkGroupByContinent_CheckedChanged);
            // 
            // btnAutosize
            // 
            this.btnAutosize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutosize.Location = new System.Drawing.Point(12, 830);
            this.btnAutosize.Name = "btnAutosize";
            this.btnAutosize.Size = new System.Drawing.Size(75, 23);
            this.btnAutosize.TabIndex = 6;
            this.btnAutosize.Text = "Autosize";
            this.btnAutosize.UseVisualStyleBackColor = true;
            this.btnAutosize.Click += new System.EventHandler(this.btnAutosize_Click);
            // 
            // checkAutoSizeOnMapSwitch
            // 
            this.checkAutoSizeOnMapSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAutoSizeOnMapSwitch.AutoSize = true;
            this.checkAutoSizeOnMapSwitch.Checked = true;
            this.checkAutoSizeOnMapSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoSizeOnMapSwitch.Location = new System.Drawing.Point(93, 836);
            this.checkAutoSizeOnMapSwitch.Name = "checkAutoSizeOnMapSwitch";
            this.checkAutoSizeOnMapSwitch.Size = new System.Drawing.Size(93, 17);
            this.checkAutoSizeOnMapSwitch.TabIndex = 7;
            this.checkAutoSizeOnMapSwitch.Text = "On Mapswitch";
            this.checkAutoSizeOnMapSwitch.UseVisualStyleBackColor = true;
            // 
            // linkLabelWiki
            // 
            this.linkLabelWiki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelWiki.AutoSize = true;
            this.linkLabelWiki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWiki.Location = new System.Drawing.Point(590, 16);
            this.linkLabelWiki.Name = "linkLabelWiki";
            this.linkLabelWiki.Size = new System.Drawing.Size(26, 13);
            this.linkLabelWiki.TabIndex = 1;
            this.linkLabelWiki.TabStop = true;
            this.linkLabelWiki.Text = "Wiki";
            this.toolTip1.SetToolTip(this.linkLabelWiki, "Open the zone\'s page on the Wiki");
            this.linkLabelWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWiki_LinkClicked);
            // 
            // sliderOpacity
            // 
            this.sliderOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderOpacity.AutoSize = false;
            this.sliderOpacity.Location = new System.Drawing.Point(525, 833);
            this.sliderOpacity.Maximum = 20;
            this.sliderOpacity.Minimum = 2;
            this.sliderOpacity.Name = "sliderOpacity";
            this.sliderOpacity.Size = new System.Drawing.Size(149, 20);
            this.sliderOpacity.TabIndex = 9;
            this.sliderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.sliderOpacity, "Opacity Level (10-100%)");
            this.sliderOpacity.Value = 20;
            this.sliderOpacity.Scroll += new System.EventHandler(this.sliderOpacity_Scroll);
            // 
            // checkAlwaysOnTop
            // 
            this.checkAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAlwaysOnTop.AutoSize = true;
            this.checkAlwaysOnTop.Location = new System.Drawing.Point(472, 836);
            this.checkAlwaysOnTop.Name = "checkAlwaysOnTop";
            this.checkAlwaysOnTop.Size = new System.Drawing.Size(47, 17);
            this.checkAlwaysOnTop.TabIndex = 8;
            this.checkAlwaysOnTop.Text = "AOT";
            this.toolTip1.SetToolTip(this.checkAlwaysOnTop, "Always-On-Top");
            this.checkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkAlwaysOnTop_CheckedChanged);
            // 
            // btnSetWaypoint
            // 
            this.btnSetWaypoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetWaypoint.Location = new System.Drawing.Point(715, 36);
            this.btnSetWaypoint.Name = "btnSetWaypoint";
            this.btnSetWaypoint.Size = new System.Drawing.Size(55, 23);
            this.btnSetWaypoint.TabIndex = 4;
            this.btnSetWaypoint.Text = "Set WP";
            this.toolTip1.SetToolTip(this.btnSetWaypoint, "Set waypoint on map");
            this.btnSetWaypoint.UseVisualStyleBackColor = true;
            this.btnSetWaypoint.Click += new System.EventHandler(this.btnSetWaypoint_Click);
            // 
            // textBoxCharName
            // 
            this.textBoxCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCharName.Location = new System.Drawing.Point(489, 13);
            this.textBoxCharName.MaxLength = 32;
            this.textBoxCharName.Name = "textBoxCharName";
            this.textBoxCharName.Size = new System.Drawing.Size(95, 21);
            this.textBoxCharName.TabIndex = 14;
            this.textBoxCharName.Text = "*";
            this.toolTip1.SetToolTip(this.textBoxCharName, "Type character name here");
            this.textBoxCharName.TextChanged += new System.EventHandler(this.textBoxCharName_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelConnectedZones);
            this.panelMain.Controls.Add(this.picBox);
            this.panelMain.Controls.Add(this.labelLegend);
            this.panelMain.Location = new System.Drawing.Point(12, 71);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(782, 753);
            this.panelMain.TabIndex = 13;
            // 
            // panelConnectedZones
            // 
            this.panelConnectedZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnectedZones.Controls.Add(this.labelConnectedZones);
            this.panelConnectedZones.Location = new System.Drawing.Point(0, 334);
            this.panelConnectedZones.Name = "panelConnectedZones";
            this.panelConnectedZones.Size = new System.Drawing.Size(779, 24);
            this.panelConnectedZones.TabIndex = 6;
            this.panelConnectedZones.WrapContents = false;
            // 
            // labelConnectedZones
            // 
            this.labelConnectedZones.AutoSize = true;
            this.labelConnectedZones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectedZones.Location = new System.Drawing.Point(3, 0);
            this.labelConnectedZones.Name = "labelConnectedZones";
            this.labelConnectedZones.Size = new System.Drawing.Size(95, 13);
            this.labelConnectedZones.TabIndex = 4;
            this.labelConnectedZones.Text = "Connected Zones:";
            // 
            // flowSubMaps
            // 
            this.flowSubMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowSubMaps.AutoScroll = true;
            this.flowSubMaps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowSubMaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowSubMaps.Location = new System.Drawing.Point(800, 71);
            this.flowSubMaps.Name = "flowSubMaps";
            this.flowSubMaps.Size = new System.Drawing.Size(129, 555);
            this.flowSubMaps.TabIndex = 7;
            // 
            // btnSettingsHelp
            // 
            this.btnSettingsHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsHelp.Location = new System.Drawing.Point(821, 830);
            this.btnSettingsHelp.Name = "btnSettingsHelp";
            this.btnSettingsHelp.Size = new System.Drawing.Size(100, 23);
            this.btnSettingsHelp.TabIndex = 12;
            this.btnSettingsHelp.Text = "Settings && Help";
            this.btnSettingsHelp.UseVisualStyleBackColor = true;
            this.btnSettingsHelp.Click += new System.EventHandler(this.btnSettingsHelp_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // txtWaypoint
            // 
            this.txtWaypoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWaypoint.Location = new System.Drawing.Point(622, 38);
            this.txtWaypoint.Name = "txtWaypoint";
            this.txtWaypoint.Size = new System.Drawing.Size(87, 21);
            this.txtWaypoint.TabIndex = 3;
            // 
            // labelCharName
            // 
            this.labelCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCharName.AutoSize = true;
            this.labelCharName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharName.Location = new System.Drawing.Point(429, 16);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(64, 13);
            this.labelCharName.TabIndex = 5;
            this.labelCharName.Text = "Char Name:";
            // 
            // labelZoneName
            // 
            this.labelZoneName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoneName.Location = new System.Drawing.Point(13, 13);
            this.labelZoneName.Name = "labelZoneName";
            this.labelZoneName.Size = new System.Drawing.Size(352, 55);
            this.labelZoneName.TabIndex = 0;
            this.labelZoneName.Text = "Zone";
            // 
            // ZlizEQMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 859);
            this.Controls.Add(this.textBoxCharName);
            this.Controls.Add(this.labelCharName);
            this.Controls.Add(this.btnSetWaypoint);
            this.Controls.Add(this.txtWaypoint);
            this.Controls.Add(this.checkAlwaysOnTop);
            this.Controls.Add(this.sliderOpacity);
            this.Controls.Add(this.btnSettingsHelp);
            this.Controls.Add(this.linkLabelWiki);
            this.Controls.Add(this.flowSubMaps);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.checkAutoSizeOnMapSwitch);
            this.Controls.Add(this.btnAutosize);
            this.Controls.Add(this.checkGroupByContinent);
            this.Controls.Add(this.comboZone);
            this.Controls.Add(this.labelZoneName);
            this.Controls.Add(this.checkEnableDirection);
            this.Controls.Add(this.checkLegend);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZlizEQMapForm";
            this.Text = "ZlizEQMap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZlizEQMapForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.ZlizEQMapForm_SizeChanged);
            this.Resize += new System.EventHandler(this.ZlizEQMapForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOpacity)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelConnectedZones.ResumeLayout(false);
            this.panelConnectedZones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picBox;
		private System.Windows.Forms.CheckBox checkLegend;
		private System.Windows.Forms.CheckBox checkEnableDirection;
		private ZlizLabel labelZoneName;
		private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel labelLegend;
		private System.Windows.Forms.ComboBox comboZone;
		private System.Windows.Forms.CheckBox checkGroupByContinent;
		private System.Windows.Forms.Button btnAutosize;
		private System.Windows.Forms.CheckBox checkAutoSizeOnMapSwitch;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label labelConnectedZones;
		private System.Windows.Forms.FlowLayoutPanel panelConnectedZones;
		private System.Windows.Forms.FlowLayoutPanel flowSubMaps;
		private System.Windows.Forms.LinkLabel linkLabelWiki;
		private System.Windows.Forms.Button btnSettingsHelp;
		private System.Windows.Forms.TrackBar sliderOpacity;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.CheckBox checkAlwaysOnTop;
		private System.Windows.Forms.Button btnSetWaypoint;
		private System.Windows.Forms.TextBox txtWaypoint;
        private System.Windows.Forms.TextBox textBoxCharName;
        private System.Windows.Forms.Label labelCharName;
    }
}

