namespace quick_color_picker
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.colorPanel = new System.Windows.Forms.Panel();
			this.rgbTextBox = new System.Windows.Forms.TextBox();
			this.rgbLabel = new System.Windows.Forms.Label();
			this.htmlLabel = new System.Windows.Forms.Label();
			this.htmlTextBox = new System.Windows.Forms.TextBox();
			this.xLabel = new System.Windows.Forms.Label();
			this.yLabel = new System.Windows.Forms.Label();
			this.colorList = new System.Windows.Forms.ListBox();
			this.cmykTextBox = new System.Windows.Forms.TextBox();
			this.cmykLabel = new System.Windows.Forms.Label();
			this.hslTextBox = new System.Windows.Forms.TextBox();
			this.hslLabel = new System.Windows.Forms.Label();
			this.rgbOneTextBox = new System.Windows.Forms.TextBox();
			this.rgbOneLabel = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.onTopButton = new System.Windows.Forms.ToolStripButton();
			this.formatButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.clearListButton = new System.Windows.Forms.ToolStripButton();
			this.deleteButton = new System.Windows.Forms.ToolStripButton();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.gradPanel1 = new System.Windows.Forms.Panel();
			this.gradPanel2 = new System.Windows.Forms.Panel();
			this.gradPanel3 = new System.Windows.Forms.Panel();
			this.gradPanel4 = new System.Windows.Forms.Panel();
			this.gradPanel = new System.Windows.Forms.Panel();
			this.copyTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.rgbOneCopyButton = new System.Windows.Forms.Button();
			this.hslCopyButton = new System.Windows.Forms.Button();
			this.cmykCopyButton = new System.Windows.Forms.Button();
			this.htmlCopyButton = new System.Windows.Forms.Button();
			this.rgbCopyButton = new System.Windows.Forms.Button();
			this.aimPictureBox = new System.Windows.Forms.PictureBox();
			this.hsvTextBox = new System.Windows.Forms.TextBox();
			this.hsvLabel = new System.Windows.Forms.Label();
			this.hsvCopyButton = new System.Windows.Forms.Button();
			this.ratioPanel = new System.Windows.Forms.Panel();
			this.ratioWhiteLabel = new System.Windows.Forms.Label();
			this.ratioBlackLabel = new System.Windows.Forms.Label();
			this.renameTextBox = new System.Windows.Forms.TextBox();
			this.renameButton = new System.Windows.Forms.Button();
			this.linearGradPictureBox = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.rgbStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.hexStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.pickColorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.copyColorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aimPictureBox)).BeginInit();
			this.ratioPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.linearGradPictureBox)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorPanel
			// 
			this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorPanel.Location = new System.Drawing.Point(9, 9);
			this.colorPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(40, 40);
			this.colorPanel.TabIndex = 2;
			// 
			// rgbTextBox
			// 
			this.rgbTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.rgbTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rgbTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbTextBox.Location = new System.Drawing.Point(138, 28);
			this.rgbTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.rgbTextBox.Multiline = true;
			this.rgbTextBox.Name = "rgbTextBox";
			this.rgbTextBox.ReadOnly = true;
			this.rgbTextBox.Size = new System.Drawing.Size(137, 20);
			this.rgbTextBox.TabIndex = 3;
			this.rgbTextBox.Text = "255, 255, 255";
			this.rgbTextBox.WordWrap = false;
			// 
			// rgbLabel
			// 
			this.rgbLabel.AutoSize = true;
			this.rgbLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbLabel.Location = new System.Drawing.Point(135, 10);
			this.rgbLabel.Margin = new System.Windows.Forms.Padding(3);
			this.rgbLabel.Name = "rgbLabel";
			this.rgbLabel.Size = new System.Drawing.Size(32, 15);
			this.rgbLabel.TabIndex = 4;
			this.rgbLabel.Text = "RGB:";
			// 
			// htmlLabel
			// 
			this.htmlLabel.AutoSize = true;
			this.htmlLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.htmlLabel.Location = new System.Drawing.Point(135, 60);
			this.htmlLabel.Margin = new System.Windows.Forms.Padding(3);
			this.htmlLabel.Name = "htmlLabel";
			this.htmlLabel.Size = new System.Drawing.Size(32, 15);
			this.htmlLabel.TabIndex = 5;
			this.htmlLabel.Text = "HEX:";
			// 
			// htmlTextBox
			// 
			this.htmlTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.htmlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.htmlTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.htmlTextBox.Location = new System.Drawing.Point(138, 78);
			this.htmlTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.htmlTextBox.Multiline = true;
			this.htmlTextBox.Name = "htmlTextBox";
			this.htmlTextBox.ReadOnly = true;
			this.htmlTextBox.Size = new System.Drawing.Size(137, 20);
			this.htmlTextBox.TabIndex = 6;
			this.htmlTextBox.Text = "#FFFFFF";
			this.htmlTextBox.WordWrap = false;
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.xLabel.Location = new System.Drawing.Point(55, 12);
			this.xLabel.Margin = new System.Windows.Forms.Padding(13, 13, 13, 3);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(26, 15);
			this.xLabel.TabIndex = 7;
			this.xLabel.Text = "X: 0";
			// 
			// yLabel
			// 
			this.yLabel.AutoSize = true;
			this.yLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.yLabel.Location = new System.Drawing.Point(55, 31);
			this.yLabel.Margin = new System.Windows.Forms.Padding(3);
			this.yLabel.Name = "yLabel";
			this.yLabel.Size = new System.Drawing.Size(26, 15);
			this.yLabel.TabIndex = 8;
			this.yLabel.Text = "Y: 0";
			// 
			// colorList
			// 
			this.colorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.colorList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.colorList.FormattingEnabled = true;
			this.colorList.ItemHeight = 17;
			this.colorList.Location = new System.Drawing.Point(309, 41);
			this.colorList.Margin = new System.Windows.Forms.Padding(0);
			this.colorList.Name = "colorList";
			this.colorList.Size = new System.Drawing.Size(151, 223);
			this.colorList.TabIndex = 1;
			this.colorList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.colorList_DrawItem);
			this.colorList.SelectedIndexChanged += new System.EventHandler(this.colorList_SelectedIndexChanged);
			// 
			// cmykTextBox
			// 
			this.cmykTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.cmykTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmykTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmykTextBox.Location = new System.Drawing.Point(138, 128);
			this.cmykTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.cmykTextBox.Multiline = true;
			this.cmykTextBox.Name = "cmykTextBox";
			this.cmykTextBox.ReadOnly = true;
			this.cmykTextBox.Size = new System.Drawing.Size(137, 20);
			this.cmykTextBox.TabIndex = 12;
			this.cmykTextBox.Text = "0, 0, 0, 0";
			this.cmykTextBox.WordWrap = false;
			// 
			// cmykLabel
			// 
			this.cmykLabel.AutoSize = true;
			this.cmykLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmykLabel.Location = new System.Drawing.Point(135, 110);
			this.cmykLabel.Margin = new System.Windows.Forms.Padding(3);
			this.cmykLabel.Name = "cmykLabel";
			this.cmykLabel.Size = new System.Drawing.Size(64, 15);
			this.cmykLabel.TabIndex = 11;
			this.cmykLabel.Text = "CMYK (%):";
			// 
			// hslTextBox
			// 
			this.hslTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.hslTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hslTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hslTextBox.Location = new System.Drawing.Point(138, 178);
			this.hslTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.hslTextBox.Multiline = true;
			this.hslTextBox.Name = "hslTextBox";
			this.hslTextBox.ReadOnly = true;
			this.hslTextBox.Size = new System.Drawing.Size(137, 20);
			this.hslTextBox.TabIndex = 16;
			this.hslTextBox.Text = "0, 0, 100";
			this.hslTextBox.WordWrap = false;
			// 
			// hslLabel
			// 
			this.hslLabel.AutoSize = true;
			this.hslLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hslLabel.Location = new System.Drawing.Point(135, 160);
			this.hslLabel.Margin = new System.Windows.Forms.Padding(3);
			this.hslLabel.Name = "hslLabel";
			this.hslLabel.Size = new System.Drawing.Size(31, 15);
			this.hslLabel.TabIndex = 15;
			this.hslLabel.Text = "HSL:";
			// 
			// rgbOneTextBox
			// 
			this.rgbOneTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.rgbOneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rgbOneTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbOneTextBox.Location = new System.Drawing.Point(138, 228);
			this.rgbOneTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.rgbOneTextBox.Multiline = true;
			this.rgbOneTextBox.Name = "rgbOneTextBox";
			this.rgbOneTextBox.ReadOnly = true;
			this.rgbOneTextBox.Size = new System.Drawing.Size(137, 20);
			this.rgbOneTextBox.TabIndex = 19;
			this.rgbOneTextBox.Text = "1; 1; 1";
			this.rgbOneTextBox.WordWrap = false;
			// 
			// rgbOneLabel
			// 
			this.rgbOneLabel.AutoSize = true;
			this.rgbOneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbOneLabel.Location = new System.Drawing.Point(135, 210);
			this.rgbOneLabel.Margin = new System.Windows.Forms.Padding(3);
			this.rgbOneLabel.Name = "rgbOneLabel";
			this.rgbOneLabel.Size = new System.Drawing.Size(61, 15);
			this.rgbOneLabel.TabIndex = 18;
			this.rgbOneLabel.Text = "RGB [0..1]:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onTopButton,
            this.formatButton,
            this.toolStripSeparator1,
            this.clearListButton,
            this.deleteButton,
            this.aboutButton});
			this.toolStrip1.Location = new System.Drawing.Point(304, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(165, 35);
			this.toolStrip1.TabIndex = 24;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// onTopButton
			// 
			this.onTopButton.AutoSize = false;
			this.onTopButton.Checked = true;
			this.onTopButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.onTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.onTopButton.Image = ((System.Drawing.Image)(resources.GetObject("onTopButton.Image")));
			this.onTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.onTopButton.Name = "onTopButton";
			this.onTopButton.Size = new System.Drawing.Size(24, 25);
			this.onTopButton.Text = "Toggle always on top | Ctrl + T";
			this.onTopButton.ToolTipText = "Always on top | Ctrl + T";
			this.onTopButton.Click += new System.EventHandler(this.onTopButton_Click);
			// 
			// formatButton
			// 
			this.formatButton.AutoSize = false;
			this.formatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.formatButton.Image = ((System.Drawing.Image)(resources.GetObject("formatButton.Image")));
			this.formatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.formatButton.Name = "formatButton";
			this.formatButton.Size = new System.Drawing.Size(24, 25);
			this.formatButton.Text = "Clear color list | Ctrl + L";
			this.formatButton.ToolTipText = "Another format | Ctrl + F";
			this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(2, 16);
			// 
			// clearListButton
			// 
			this.clearListButton.AutoSize = false;
			this.clearListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clearListButton.Image = ((System.Drawing.Image)(resources.GetObject("clearListButton.Image")));
			this.clearListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.clearListButton.Name = "clearListButton";
			this.clearListButton.Size = new System.Drawing.Size(24, 25);
			this.clearListButton.Text = "Clear color list | Ctrl + L";
			this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.AutoSize = false;
			this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteButton.Enabled = false;
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(24, 25);
			this.deleteButton.Text = "Delete selected color | Delete";
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutButton.AutoSize = false;
			this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(24, 25);
			this.aboutButton.Text = "About | F1";
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// gradPanel1
			// 
			this.gradPanel1.BackColor = System.Drawing.Color.White;
			this.gradPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel1.Location = new System.Drawing.Point(9, 187);
			this.gradPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel1.Name = "gradPanel1";
			this.gradPanel1.Size = new System.Drawing.Size(24, 24);
			this.gradPanel1.TabIndex = 26;
			this.gradPanel1.Click += new System.EventHandler(this.gradPanel_Click);
			// 
			// gradPanel2
			// 
			this.gradPanel2.BackColor = System.Drawing.Color.White;
			this.gradPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel2.Location = new System.Drawing.Point(33, 187);
			this.gradPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel2.Name = "gradPanel2";
			this.gradPanel2.Size = new System.Drawing.Size(24, 24);
			this.gradPanel2.TabIndex = 27;
			this.gradPanel2.Click += new System.EventHandler(this.gradPanel_Click);
			// 
			// gradPanel3
			// 
			this.gradPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.gradPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel3.Location = new System.Drawing.Point(81, 187);
			this.gradPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel3.Name = "gradPanel3";
			this.gradPanel3.Size = new System.Drawing.Size(24, 24);
			this.gradPanel3.TabIndex = 27;
			this.gradPanel3.Click += new System.EventHandler(this.gradPanel_Click);
			// 
			// gradPanel4
			// 
			this.gradPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
			this.gradPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel4.Location = new System.Drawing.Point(105, 187);
			this.gradPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel4.Name = "gradPanel4";
			this.gradPanel4.Size = new System.Drawing.Size(24, 24);
			this.gradPanel4.TabIndex = 27;
			this.gradPanel4.Click += new System.EventHandler(this.gradPanel_Click);
			// 
			// gradPanel
			// 
			this.gradPanel.BackColor = System.Drawing.Color.White;
			this.gradPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel.Location = new System.Drawing.Point(57, 187);
			this.gradPanel.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel.Name = "gradPanel";
			this.gradPanel.Size = new System.Drawing.Size(24, 24);
			this.gradPanel.TabIndex = 28;
			this.gradPanel.Click += new System.EventHandler(this.gradPanel_Click);
			// 
			// rgbOneCopyButton
			// 
			this.rgbOneCopyButton.FlatAppearance.BorderSize = 0;
			this.rgbOneCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rgbOneCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("rgbOneCopyButton.Image")));
			this.rgbOneCopyButton.Location = new System.Drawing.Point(277, 225);
			this.rgbOneCopyButton.Name = "rgbOneCopyButton";
			this.rgbOneCopyButton.Size = new System.Drawing.Size(25, 25);
			this.rgbOneCopyButton.TabIndex = 20;
			this.rgbOneCopyButton.UseVisualStyleBackColor = true;
			this.rgbOneCopyButton.Click += new System.EventHandler(this.rgbOneCopyButton_Click);
			// 
			// hslCopyButton
			// 
			this.hslCopyButton.FlatAppearance.BorderSize = 0;
			this.hslCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.hslCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("hslCopyButton.Image")));
			this.hslCopyButton.Location = new System.Drawing.Point(277, 175);
			this.hslCopyButton.Name = "hslCopyButton";
			this.hslCopyButton.Size = new System.Drawing.Size(25, 25);
			this.hslCopyButton.TabIndex = 17;
			this.hslCopyButton.UseVisualStyleBackColor = true;
			this.hslCopyButton.Click += new System.EventHandler(this.hslCopyButton_Click);
			// 
			// cmykCopyButton
			// 
			this.cmykCopyButton.FlatAppearance.BorderSize = 0;
			this.cmykCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmykCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("cmykCopyButton.Image")));
			this.cmykCopyButton.Location = new System.Drawing.Point(277, 125);
			this.cmykCopyButton.Name = "cmykCopyButton";
			this.cmykCopyButton.Size = new System.Drawing.Size(25, 25);
			this.cmykCopyButton.TabIndex = 14;
			this.cmykCopyButton.UseVisualStyleBackColor = true;
			this.cmykCopyButton.Click += new System.EventHandler(this.cmykCopyButton_Click);
			// 
			// htmlCopyButton
			// 
			this.htmlCopyButton.FlatAppearance.BorderSize = 0;
			this.htmlCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.htmlCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("htmlCopyButton.Image")));
			this.htmlCopyButton.Location = new System.Drawing.Point(277, 75);
			this.htmlCopyButton.Name = "htmlCopyButton";
			this.htmlCopyButton.Size = new System.Drawing.Size(25, 25);
			this.htmlCopyButton.TabIndex = 10;
			this.htmlCopyButton.UseVisualStyleBackColor = true;
			this.htmlCopyButton.Click += new System.EventHandler(this.htmlCopyButton_Click);
			// 
			// rgbCopyButton
			// 
			this.rgbCopyButton.FlatAppearance.BorderSize = 0;
			this.rgbCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rgbCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("rgbCopyButton.Image")));
			this.rgbCopyButton.Location = new System.Drawing.Point(277, 25);
			this.rgbCopyButton.Name = "rgbCopyButton";
			this.rgbCopyButton.Size = new System.Drawing.Size(25, 25);
			this.rgbCopyButton.TabIndex = 9;
			this.rgbCopyButton.UseVisualStyleBackColor = true;
			this.rgbCopyButton.Click += new System.EventHandler(this.rgbCopyButton_Click);
			// 
			// aimPictureBox
			// 
			this.aimPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.aimPictureBox.Location = new System.Drawing.Point(9, 58);
			this.aimPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.aimPictureBox.Name = "aimPictureBox";
			this.aimPictureBox.Size = new System.Drawing.Size(120, 120);
			this.aimPictureBox.TabIndex = 0;
			this.aimPictureBox.TabStop = false;
			// 
			// hsvTextBox
			// 
			this.hsvTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.hsvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hsvTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hsvTextBox.Location = new System.Drawing.Point(138, 278);
			this.hsvTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.hsvTextBox.Multiline = true;
			this.hsvTextBox.Name = "hsvTextBox";
			this.hsvTextBox.ReadOnly = true;
			this.hsvTextBox.Size = new System.Drawing.Size(137, 20);
			this.hsvTextBox.TabIndex = 30;
			this.hsvTextBox.Text = "0, 0, 100";
			this.hsvTextBox.WordWrap = false;
			// 
			// hsvLabel
			// 
			this.hsvLabel.AutoSize = true;
			this.hsvLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hsvLabel.Location = new System.Drawing.Point(135, 260);
			this.hsvLabel.Margin = new System.Windows.Forms.Padding(3);
			this.hsvLabel.Name = "hsvLabel";
			this.hsvLabel.Size = new System.Drawing.Size(65, 15);
			this.hsvLabel.TabIndex = 29;
			this.hsvLabel.Text = "HSB / HSV:";
			// 
			// hsvCopyButton
			// 
			this.hsvCopyButton.FlatAppearance.BorderSize = 0;
			this.hsvCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.hsvCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("hsvCopyButton.Image")));
			this.hsvCopyButton.Location = new System.Drawing.Point(277, 275);
			this.hsvCopyButton.Name = "hsvCopyButton";
			this.hsvCopyButton.Size = new System.Drawing.Size(25, 25);
			this.hsvCopyButton.TabIndex = 31;
			this.hsvCopyButton.UseVisualStyleBackColor = true;
			this.hsvCopyButton.Click += new System.EventHandler(this.hsvCopyButton_Click);
			// 
			// ratioPanel
			// 
			this.ratioPanel.BackColor = System.Drawing.Color.White;
			this.ratioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ratioPanel.Controls.Add(this.ratioWhiteLabel);
			this.ratioPanel.Controls.Add(this.ratioBlackLabel);
			this.ratioPanel.Location = new System.Drawing.Point(9, 253);
			this.ratioPanel.Margin = new System.Windows.Forms.Padding(0);
			this.ratioPanel.Name = "ratioPanel";
			this.ratioPanel.Size = new System.Drawing.Size(120, 45);
			this.ratioPanel.TabIndex = 32;
			// 
			// ratioWhiteLabel
			// 
			this.ratioWhiteLabel.AutoSize = true;
			this.ratioWhiteLabel.BackColor = System.Drawing.Color.Transparent;
			this.ratioWhiteLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ratioWhiteLabel.ForeColor = System.Drawing.Color.White;
			this.ratioWhiteLabel.Location = new System.Drawing.Point(65, 14);
			this.ratioWhiteLabel.Margin = new System.Windows.Forms.Padding(3);
			this.ratioWhiteLabel.Name = "ratioWhiteLabel";
			this.ratioWhiteLabel.Size = new System.Drawing.Size(41, 15);
			this.ratioWhiteLabel.TabIndex = 34;
			this.ratioWhiteLabel.Text = "White";
			// 
			// ratioBlackLabel
			// 
			this.ratioBlackLabel.AutoSize = true;
			this.ratioBlackLabel.BackColor = System.Drawing.Color.Transparent;
			this.ratioBlackLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ratioBlackLabel.ForeColor = System.Drawing.Color.Black;
			this.ratioBlackLabel.Location = new System.Drawing.Point(13, 14);
			this.ratioBlackLabel.Margin = new System.Windows.Forms.Padding(3);
			this.ratioBlackLabel.Name = "ratioBlackLabel";
			this.ratioBlackLabel.Size = new System.Drawing.Size(37, 15);
			this.ratioBlackLabel.TabIndex = 33;
			this.ratioBlackLabel.Text = "Black";
			// 
			// renameTextBox
			// 
			this.renameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.renameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.renameTextBox.Enabled = false;
			this.renameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.renameTextBox.Location = new System.Drawing.Point(309, 278);
			this.renameTextBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
			this.renameTextBox.Name = "renameTextBox";
			this.renameTextBox.Size = new System.Drawing.Size(124, 23);
			this.renameTextBox.TabIndex = 33;
			this.renameTextBox.WordWrap = false;
			this.renameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.renameTextBox_KeyUp);
			// 
			// renameButton
			// 
			this.renameButton.Enabled = false;
			this.renameButton.FlatAppearance.BorderSize = 0;
			this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.renameButton.Image = ((System.Drawing.Image)(resources.GetObject("renameButton.Image")));
			this.renameButton.Location = new System.Drawing.Point(435, 275);
			this.renameButton.Name = "renameButton";
			this.renameButton.Size = new System.Drawing.Size(25, 25);
			this.renameButton.TabIndex = 34;
			this.renameButton.UseVisualStyleBackColor = true;
			this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
			// 
			// linearGradPictureBox
			// 
			this.linearGradPictureBox.BackColor = System.Drawing.Color.White;
			this.linearGradPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.linearGradPictureBox.Location = new System.Drawing.Point(9, 220);
			this.linearGradPictureBox.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.linearGradPictureBox.Name = "linearGradPictureBox";
			this.linearGradPictureBox.Size = new System.Drawing.Size(120, 24);
			this.linearGradPictureBox.TabIndex = 35;
			this.linearGradPictureBox.TabStop = false;
			this.linearGradPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linearGradPictureBox_MouseClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickColorStatusLabel,
            this.copyColorStatusLabel,
            this.rgbStatusLabel,
            this.hexStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 307);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(469, 25);
			this.statusStrip1.TabIndex = 36;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// rgbStatusLabel
			// 
			this.rgbStatusLabel.Margin = new System.Windows.Forms.Padding(5);
			this.rgbStatusLabel.Name = "rgbStatusLabel";
			this.rgbStatusLabel.Size = new System.Drawing.Size(101, 15);
			this.rgbStatusLabel.Text = "RGB: 255, 255, 255";
			// 
			// hexStatusLabel
			// 
			this.hexStatusLabel.Margin = new System.Windows.Forms.Padding(5);
			this.hexStatusLabel.Name = "hexStatusLabel";
			this.hexStatusLabel.Size = new System.Drawing.Size(78, 15);
			this.hexStatusLabel.Text = "HEX: #FFFFFF";
			// 
			// pickColorStatusLabel
			// 
			this.pickColorStatusLabel.Margin = new System.Windows.Forms.Padding(5);
			this.pickColorStatusLabel.Name = "pickColorStatusLabel";
			this.pickColorStatusLabel.Size = new System.Drawing.Size(98, 15);
			this.pickColorStatusLabel.Text = "Pick color: Alt +X";
			// 
			// copyColorStatusLabel
			// 
			this.copyColorStatusLabel.Margin = new System.Windows.Forms.Padding(5);
			this.copyColorStatusLabel.Name = "copyColorStatusLabel";
			this.copyColorStatusLabel.Size = new System.Drawing.Size(108, 15);
			this.copyColorStatusLabel.Text = "Copy color: Alt + C";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(469, 332);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.linearGradPictureBox);
			this.Controls.Add(this.renameButton);
			this.Controls.Add(this.renameTextBox);
			this.Controls.Add(this.ratioPanel);
			this.Controls.Add(this.hsvCopyButton);
			this.Controls.Add(this.hsvTextBox);
			this.Controls.Add(this.hsvLabel);
			this.Controls.Add(this.gradPanel);
			this.Controls.Add(this.gradPanel4);
			this.Controls.Add(this.gradPanel3);
			this.Controls.Add(this.gradPanel2);
			this.Controls.Add(this.gradPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.rgbOneCopyButton);
			this.Controls.Add(this.rgbOneTextBox);
			this.Controls.Add(this.rgbOneLabel);
			this.Controls.Add(this.hslCopyButton);
			this.Controls.Add(this.hslTextBox);
			this.Controls.Add(this.hslLabel);
			this.Controls.Add(this.cmykCopyButton);
			this.Controls.Add(this.cmykTextBox);
			this.Controls.Add(this.cmykLabel);
			this.Controls.Add(this.htmlCopyButton);
			this.Controls.Add(this.rgbCopyButton);
			this.Controls.Add(this.yLabel);
			this.Controls.Add(this.xLabel);
			this.Controls.Add(this.htmlTextBox);
			this.Controls.Add(this.htmlLabel);
			this.Controls.Add(this.rgbLabel);
			this.Controls.Add(this.rgbTextBox);
			this.Controls.Add(this.colorPanel);
			this.Controls.Add(this.colorList);
			this.Controls.Add(this.aimPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Color Picker";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aimPictureBox)).EndInit();
			this.ratioPanel.ResumeLayout(false);
			this.ratioPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.linearGradPictureBox)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox aimPictureBox;
		private System.Windows.Forms.Panel colorPanel;
		private System.Windows.Forms.TextBox rgbTextBox;
		private System.Windows.Forms.Label rgbLabel;
		private System.Windows.Forms.Label htmlLabel;
		private System.Windows.Forms.TextBox htmlTextBox;
		private System.Windows.Forms.Label xLabel;
		private System.Windows.Forms.Label yLabel;
		private System.Windows.Forms.ListBox colorList;
		private System.Windows.Forms.Button rgbCopyButton;
		private System.Windows.Forms.Button htmlCopyButton;
		private System.Windows.Forms.Button cmykCopyButton;
		private System.Windows.Forms.TextBox cmykTextBox;
		private System.Windows.Forms.Label cmykLabel;
		private System.Windows.Forms.Button hslCopyButton;
		private System.Windows.Forms.TextBox hslTextBox;
		private System.Windows.Forms.Label hslLabel;
		private System.Windows.Forms.Button rgbOneCopyButton;
		private System.Windows.Forms.TextBox rgbOneTextBox;
		private System.Windows.Forms.Label rgbOneLabel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton onTopButton;
		private System.Windows.Forms.ToolStripButton clearListButton;
		private System.Windows.Forms.ToolStripButton aboutButton;
		private System.Windows.Forms.ToolStripButton deleteButton;
		private System.Windows.Forms.Panel gradPanel1;
		private System.Windows.Forms.Panel gradPanel2;
		private System.Windows.Forms.Panel gradPanel3;
		private System.Windows.Forms.Panel gradPanel4;
		private System.Windows.Forms.Panel gradPanel;
		private System.Windows.Forms.ToolStripButton formatButton;
		private System.Windows.Forms.ToolTip copyTooltip;
		private System.Windows.Forms.TextBox hsvTextBox;
		private System.Windows.Forms.Label hsvLabel;
		private System.Windows.Forms.Button hsvCopyButton;
		private System.Windows.Forms.Panel ratioPanel;
		private System.Windows.Forms.Label ratioBlackLabel;
		private System.Windows.Forms.Label ratioWhiteLabel;
		private System.Windows.Forms.TextBox renameTextBox;
		private System.Windows.Forms.Button renameButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.PictureBox linearGradPictureBox;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel rgbStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel hexStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel pickColorStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel copyColorStatusLabel;
	}
}

