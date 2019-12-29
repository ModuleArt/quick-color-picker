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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.colorPanel = new System.Windows.Forms.Panel();
			this.rgbTextBox = new System.Windows.Forms.TextBox();
			this.rgbLabel = new System.Windows.Forms.Label();
			this.htmlLabel = new System.Windows.Forms.Label();
			this.htmlTextBox = new System.Windows.Forms.TextBox();
			this.xLabel = new System.Windows.Forms.Label();
			this.yLabel = new System.Windows.Forms.Label();
			this.colorList = new System.Windows.Forms.ListBox();
			this.rgbCopyButton = new System.Windows.Forms.Button();
			this.htmlCopyButton = new System.Windows.Forms.Button();
			this.cmykCopyButton = new System.Windows.Forms.Button();
			this.cmykTextBox = new System.Windows.Forms.TextBox();
			this.cmykLabel = new System.Windows.Forms.Label();
			this.hslCopyButton = new System.Windows.Forms.Button();
			this.hslTextBox = new System.Windows.Forms.TextBox();
			this.hslLabel = new System.Windows.Forms.Label();
			this.rgbOneCopyButton = new System.Windows.Forms.Button();
			this.rgbOneTextBox = new System.Windows.Forms.TextBox();
			this.rgbOneLabel = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.onTopButton = new System.Windows.Forms.ToolStripButton();
			this.clearListButton = new System.Windows.Forms.ToolStripButton();
			this.deleteButton = new System.Windows.Forms.ToolStripButton();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.gradPanel1 = new System.Windows.Forms.Panel();
			this.gradPanel2 = new System.Windows.Forms.Panel();
			this.gradPanel3 = new System.Windows.Forms.Panel();
			this.gradPanel4 = new System.Windows.Forms.Panel();
			this.gridPanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(9, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// colorPanel
			// 
			this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorPanel.Location = new System.Drawing.Point(9, 139);
			this.colorPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(40, 40);
			this.colorPanel.TabIndex = 2;
			// 
			// rgbTextBox
			// 
			this.rgbTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbTextBox.Location = new System.Drawing.Point(139, 27);
			this.rgbTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
			this.rgbTextBox.Name = "rgbTextBox";
			this.rgbTextBox.ReadOnly = true;
			this.rgbTextBox.Size = new System.Drawing.Size(100, 23);
			this.rgbTextBox.TabIndex = 3;
			this.rgbTextBox.Text = "255,255,255";
			// 
			// rgbLabel
			// 
			this.rgbLabel.AutoSize = true;
			this.rgbLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbLabel.Location = new System.Drawing.Point(136, 9);
			this.rgbLabel.Name = "rgbLabel";
			this.rgbLabel.Size = new System.Drawing.Size(32, 15);
			this.rgbLabel.TabIndex = 4;
			this.rgbLabel.Text = "RGB:";
			// 
			// htmlLabel
			// 
			this.htmlLabel.AutoSize = true;
			this.htmlLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.htmlLabel.Location = new System.Drawing.Point(136, 61);
			this.htmlLabel.Name = "htmlLabel";
			this.htmlLabel.Size = new System.Drawing.Size(42, 15);
			this.htmlLabel.TabIndex = 5;
			this.htmlLabel.Text = "HTML:";
			// 
			// htmlTextBox
			// 
			this.htmlTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.htmlTextBox.Location = new System.Drawing.Point(139, 79);
			this.htmlTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.htmlTextBox.Name = "htmlTextBox";
			this.htmlTextBox.ReadOnly = true;
			this.htmlTextBox.Size = new System.Drawing.Size(100, 23);
			this.htmlTextBox.TabIndex = 6;
			this.htmlTextBox.Text = "#FFFFFF";
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.xLabel.Location = new System.Drawing.Point(55, 142);
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
			this.yLabel.Location = new System.Drawing.Point(55, 161);
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
			this.colorList.Location = new System.Drawing.Point(275, 36);
			this.colorList.Margin = new System.Windows.Forms.Padding(0);
			this.colorList.Name = "colorList";
			this.colorList.Size = new System.Drawing.Size(120, 223);
			this.colorList.TabIndex = 1;
			this.colorList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.colorList_DrawItem);
			this.colorList.SelectedIndexChanged += new System.EventHandler(this.colorList_SelectedIndexChanged);
			// 
			// rgbCopyButton
			// 
			this.rgbCopyButton.FlatAppearance.BorderSize = 0;
			this.rgbCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rgbCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("rgbCopyButton.Image")));
			this.rgbCopyButton.Location = new System.Drawing.Point(240, 26);
			this.rgbCopyButton.Name = "rgbCopyButton";
			this.rgbCopyButton.Size = new System.Drawing.Size(25, 25);
			this.rgbCopyButton.TabIndex = 9;
			this.rgbCopyButton.UseVisualStyleBackColor = true;
			this.rgbCopyButton.Click += new System.EventHandler(this.rgbCopyButton_Click);
			// 
			// htmlCopyButton
			// 
			this.htmlCopyButton.FlatAppearance.BorderSize = 0;
			this.htmlCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.htmlCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("htmlCopyButton.Image")));
			this.htmlCopyButton.Location = new System.Drawing.Point(240, 78);
			this.htmlCopyButton.Name = "htmlCopyButton";
			this.htmlCopyButton.Size = new System.Drawing.Size(25, 25);
			this.htmlCopyButton.TabIndex = 10;
			this.htmlCopyButton.UseVisualStyleBackColor = true;
			this.htmlCopyButton.Click += new System.EventHandler(this.htmlCopyButton_Click);
			// 
			// cmykCopyButton
			// 
			this.cmykCopyButton.FlatAppearance.BorderSize = 0;
			this.cmykCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmykCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("cmykCopyButton.Image")));
			this.cmykCopyButton.Location = new System.Drawing.Point(240, 130);
			this.cmykCopyButton.Name = "cmykCopyButton";
			this.cmykCopyButton.Size = new System.Drawing.Size(25, 25);
			this.cmykCopyButton.TabIndex = 14;
			this.cmykCopyButton.UseVisualStyleBackColor = true;
			this.cmykCopyButton.Click += new System.EventHandler(this.cmykCopyButton_Click);
			// 
			// cmykTextBox
			// 
			this.cmykTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmykTextBox.Location = new System.Drawing.Point(139, 131);
			this.cmykTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.cmykTextBox.Name = "cmykTextBox";
			this.cmykTextBox.ReadOnly = true;
			this.cmykTextBox.Size = new System.Drawing.Size(100, 23);
			this.cmykTextBox.TabIndex = 12;
			this.cmykTextBox.Text = "0,0,0,0";
			// 
			// cmykLabel
			// 
			this.cmykLabel.AutoSize = true;
			this.cmykLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmykLabel.Location = new System.Drawing.Point(136, 113);
			this.cmykLabel.Name = "cmykLabel";
			this.cmykLabel.Size = new System.Drawing.Size(64, 15);
			this.cmykLabel.TabIndex = 11;
			this.cmykLabel.Text = "CMYK (%):";
			// 
			// hslCopyButton
			// 
			this.hslCopyButton.FlatAppearance.BorderSize = 0;
			this.hslCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.hslCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("hslCopyButton.Image")));
			this.hslCopyButton.Location = new System.Drawing.Point(240, 182);
			this.hslCopyButton.Name = "hslCopyButton";
			this.hslCopyButton.Size = new System.Drawing.Size(25, 25);
			this.hslCopyButton.TabIndex = 17;
			this.hslCopyButton.UseVisualStyleBackColor = true;
			this.hslCopyButton.Click += new System.EventHandler(this.hslCopyButton_Click);
			// 
			// hslTextBox
			// 
			this.hslTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hslTextBox.Location = new System.Drawing.Point(139, 183);
			this.hslTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.hslTextBox.Name = "hslTextBox";
			this.hslTextBox.ReadOnly = true;
			this.hslTextBox.Size = new System.Drawing.Size(100, 23);
			this.hslTextBox.TabIndex = 16;
			this.hslTextBox.Text = "0,0,100";
			// 
			// hslLabel
			// 
			this.hslLabel.AutoSize = true;
			this.hslLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.hslLabel.Location = new System.Drawing.Point(136, 165);
			this.hslLabel.Name = "hslLabel";
			this.hslLabel.Size = new System.Drawing.Size(52, 15);
			this.hslLabel.TabIndex = 15;
			this.hslLabel.Text = "HSL (%):";
			// 
			// rgbOneCopyButton
			// 
			this.rgbOneCopyButton.FlatAppearance.BorderSize = 0;
			this.rgbOneCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rgbOneCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("rgbOneCopyButton.Image")));
			this.rgbOneCopyButton.Location = new System.Drawing.Point(240, 234);
			this.rgbOneCopyButton.Name = "rgbOneCopyButton";
			this.rgbOneCopyButton.Size = new System.Drawing.Size(25, 25);
			this.rgbOneCopyButton.TabIndex = 20;
			this.rgbOneCopyButton.UseVisualStyleBackColor = true;
			this.rgbOneCopyButton.Click += new System.EventHandler(this.rgbOneCopyButton_Click);
			// 
			// rgbOneTextBox
			// 
			this.rgbOneTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbOneTextBox.Location = new System.Drawing.Point(139, 235);
			this.rgbOneTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
			this.rgbOneTextBox.Name = "rgbOneTextBox";
			this.rgbOneTextBox.ReadOnly = true;
			this.rgbOneTextBox.Size = new System.Drawing.Size(100, 23);
			this.rgbOneTextBox.TabIndex = 19;
			this.rgbOneTextBox.Text = "1/1/1";
			// 
			// rgbOneLabel
			// 
			this.rgbOneLabel.AutoSize = true;
			this.rgbOneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rgbOneLabel.Location = new System.Drawing.Point(136, 217);
			this.rgbOneLabel.Name = "rgbOneLabel";
			this.rgbOneLabel.Size = new System.Drawing.Size(61, 15);
			this.rgbOneLabel.TabIndex = 18;
			this.rgbOneLabel.Text = "RGB [0..1]:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onTopButton,
            this.clearListButton,
            this.deleteButton,
            this.aboutButton});
			this.toolStrip1.Location = new System.Drawing.Point(270, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(134, 35);
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
			this.onTopButton.Click += new System.EventHandler(this.onTopButton_Click);
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
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(24, 25);
			this.deleteButton.Text = "Remove selected color | Delete";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 188);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 15);
			this.label1.TabIndex = 25;
			this.label1.Text = "Pick color: Alt + X";
			// 
			// gradPanel1
			// 
			this.gradPanel1.BackColor = System.Drawing.Color.White;
			this.gradPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel1.Location = new System.Drawing.Point(9, 213);
			this.gradPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel1.Name = "gradPanel1";
			this.gradPanel1.Size = new System.Drawing.Size(24, 46);
			this.gradPanel1.TabIndex = 26;
			// 
			// gradPanel2
			// 
			this.gradPanel2.BackColor = System.Drawing.Color.White;
			this.gradPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel2.Location = new System.Drawing.Point(33, 213);
			this.gradPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel2.Name = "gradPanel2";
			this.gradPanel2.Size = new System.Drawing.Size(24, 46);
			this.gradPanel2.TabIndex = 27;
			// 
			// gradPanel3
			// 
			this.gradPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.gradPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel3.Location = new System.Drawing.Point(81, 213);
			this.gradPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel3.Name = "gradPanel3";
			this.gradPanel3.Size = new System.Drawing.Size(24, 46);
			this.gradPanel3.TabIndex = 27;
			// 
			// gradPanel4
			// 
			this.gradPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
			this.gradPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradPanel4.Location = new System.Drawing.Point(105, 213);
			this.gradPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.gradPanel4.Name = "gradPanel4";
			this.gradPanel4.Size = new System.Drawing.Size(24, 46);
			this.gradPanel4.TabIndex = 27;
			// 
			// gridPanel
			// 
			this.gridPanel.BackColor = System.Drawing.Color.White;
			this.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridPanel.Location = new System.Drawing.Point(57, 213);
			this.gridPanel.Margin = new System.Windows.Forms.Padding(0);
			this.gridPanel.Name = "gridPanel";
			this.gridPanel.Size = new System.Drawing.Size(24, 46);
			this.gridPanel.TabIndex = 28;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(404, 268);
			this.Controls.Add(this.gridPanel);
			this.Controls.Add(this.gradPanel4);
			this.Controls.Add(this.gradPanel3);
			this.Controls.Add(this.gradPanel2);
			this.Controls.Add(this.gradPanel1);
			this.Controls.Add(this.label1);
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
			this.Controls.Add(this.pictureBox1);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel gradPanel1;
		private System.Windows.Forms.Panel gradPanel2;
		private System.Windows.Forms.Panel gradPanel3;
		private System.Windows.Forms.Panel gradPanel4;
		private System.Windows.Forms.Panel gridPanel;
	}
}

