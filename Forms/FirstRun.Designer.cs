namespace ZlizEQMap
{
	partial class FirstRun
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRun));
			this.label1 = new System.Windows.Forms.Label();
			this.txtEQDirectory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEnableLogging = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.labelLogStatus = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.radioLogsRoot = new System.Windows.Forms.RadioButton();
			this.radioLogsLogs = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboZoneData = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to ZlizEQMap!";
			// 
			// txtEQDirectory
			// 
			this.txtEQDirectory.Location = new System.Drawing.Point(12, 36);
			this.txtEQDirectory.Name = "txtEQDirectory";
			this.txtEQDirectory.Size = new System.Drawing.Size(360, 21);
			this.txtEQDirectory.TabIndex = 1;
			this.txtEQDirectory.TextChanged += new System.EventHandler(this.txtEQDirectory_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Path to EverQuest directory:";
			// 
			// btnEnableLogging
			// 
			this.btnEnableLogging.Enabled = false;
			this.btnEnableLogging.Location = new System.Drawing.Point(9, 40);
			this.btnEnableLogging.Name = "btnEnableLogging";
			this.btnEnableLogging.Size = new System.Drawing.Size(140, 23);
			this.btnEnableLogging.TabIndex = 3;
			this.btnEnableLogging.Text = "Enable EQ Logging";
			this.btnEnableLogging.UseVisualStyleBackColor = true;
			this.btnEnableLogging.Click += new System.EventHandler(this.btnEnableLogging_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(431, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Click the button below to enable permanent logging in EQ (sets Log=True in eqclie" +
    "nt.ini).";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Select your EverQuest directory path (not the log directory)";
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(378, 36);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 5;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(210, 303);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(442, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Since this is your first time running the application, you must set your EverQues" +
    "t directory.";
			// 
			// labelLogStatus
			// 
			this.labelLogStatus.AutoSize = true;
			this.labelLogStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogStatus.ForeColor = System.Drawing.Color.DarkRed;
			this.labelLogStatus.Location = new System.Drawing.Point(159, 249);
			this.labelLogStatus.Name = "labelLogStatus";
			this.labelLogStatus.Size = new System.Drawing.Size(0, 13);
			this.labelLogStatus.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(432, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "This dialog might also be shown because the previously saved directory no longer " +
    "exists.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Log files location:";
			// 
			// radioLogsRoot
			// 
			this.radioLogsRoot.AutoSize = true;
			this.radioLogsRoot.Location = new System.Drawing.Point(211, 90);
			this.radioLogsRoot.Name = "radioLogsRoot";
			this.radioLogsRoot.Size = new System.Drawing.Size(94, 17);
			this.radioLogsRoot.TabIndex = 10;
			this.radioLogsRoot.Text = "Root directory";
			this.radioLogsRoot.UseVisualStyleBackColor = true;
			// 
			// radioLogsLogs
			// 
			this.radioLogsLogs.AutoSize = true;
			this.radioLogsLogs.Checked = true;
			this.radioLogsLogs.Location = new System.Drawing.Point(108, 90);
			this.radioLogsLogs.Name = "radioLogsLogs";
			this.radioLogsLogs.Size = new System.Drawing.Size(97, 17);
			this.radioLogsLogs.TabIndex = 9;
			this.radioLogsLogs.TabStop = true;
			this.radioLogsLogs.Text = "\\Logs directory";
			this.radioLogsLogs.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnEnableLogging);
			this.groupBox1.Location = new System.Drawing.Point(15, 217);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(467, 77);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.comboZoneData);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtEQDirectory);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.btnBrowse);
			this.groupBox2.Controls.Add(this.radioLogsRoot);
			this.groupBox2.Controls.Add(this.radioLogsLogs);
			this.groupBox2.Location = new System.Drawing.Point(15, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(467, 134);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			// 
			// comboZoneData
			// 
			this.comboZoneData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboZoneData.FormattingEnabled = true;
			this.comboZoneData.Location = new System.Drawing.Point(94, 63);
			this.comboZoneData.Name = "comboZoneData";
			this.comboZoneData.Size = new System.Drawing.Size(139, 21);
			this.comboZoneData.TabIndex = 13;
			this.comboZoneData.SelectedIndexChanged += new System.EventHandler(this.comboZoneData_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Zone Dataset:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.ForeColor = System.Drawing.Color.DarkRed;
			this.label7.Location = new System.Drawing.Point(12, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(407, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Tip: For Project1999, choose \'\\Logs directory\'. For EQMac, choose \'Root directory" +
    "\'.";
			// 
			// FirstRun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 338);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelLogStatus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FirstRun";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ZlizEQMap";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEQDirectory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEnableLogging;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelLogStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioLogsRoot;
		private System.Windows.Forms.RadioButton radioLogsLogs;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboZoneData;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}