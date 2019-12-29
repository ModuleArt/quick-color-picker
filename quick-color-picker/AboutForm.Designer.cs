﻿namespace quick_color_picker
{
	partial class AboutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.productLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.companyLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.developerLink = new System.Windows.Forms.LinkLabel();
			this.projectLink = new System.Windows.Forms.LinkLabel();
			this.okButton = new System.Windows.Forms.Button();
			this.infoGroup = new System.Windows.Forms.GroupBox();
			this.updatesLink = new System.Windows.Forms.LinkLabel();
			this.issuesLink = new System.Windows.Forms.LinkLabel();
			this.pagesGroup = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.infoGroup.SuspendLayout();
			this.pagesGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(256, 100);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// productLabel
			// 
			this.productLabel.AutoSize = true;
			this.productLabel.Location = new System.Drawing.Point(6, 26);
			this.productLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(95, 13);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Color Picker";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(6, 45);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(42, 13);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "Version";
			// 
			// companyLabel
			// 
			this.companyLabel.AutoSize = true;
			this.companyLabel.Location = new System.Drawing.Point(6, 97);
			this.companyLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(72, 13);
			this.companyLabel.TabIndex = 29;
			this.companyLabel.Text = "by Module Art";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(6, 116);
			this.authorLabel.Margin = new System.Windows.Forms.Padding(3);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(122, 13);
			this.authorLabel.TabIndex = 30;
			this.authorLabel.Text = "Author: Eugene Volynko";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(6, 142);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(181, 13);
			this.descriptionLabel.TabIndex = 31;
			this.descriptionLabel.Text = "Lightweight color picker for Windows";
			// 
			// developerLink
			// 
			this.developerLink.AutoSize = true;
			this.developerLink.Location = new System.Drawing.Point(6, 26);
			this.developerLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.developerLink.Name = "developerLink";
			this.developerLink.Size = new System.Drawing.Size(58, 13);
			this.developerLink.TabIndex = 32;
			this.developerLink.TabStop = true;
			this.developerLink.Text = "Module Art";
			this.developerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
			// 
			// projectLink
			// 
			this.projectLink.AutoSize = true;
			this.projectLink.Location = new System.Drawing.Point(70, 26);
			this.projectLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.projectLink.Name = "projectLink";
			this.projectLink.Size = new System.Drawing.Size(67, 13);
			this.projectLink.TabIndex = 33;
			this.projectLink.TabStop = true;
			this.projectLink.Text = "Project page";
			this.projectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectLink_LinkClicked);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.okButton.Location = new System.Drawing.Point(190, 357);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 21;
			this.okButton.Text = "&OK";
			// 
			// infoGroup
			// 
			this.infoGroup.Controls.Add(this.updatesLink);
			this.infoGroup.Controls.Add(this.versionLabel);
			this.infoGroup.Controls.Add(this.companyLabel);
			this.infoGroup.Controls.Add(this.productLabel);
			this.infoGroup.Controls.Add(this.descriptionLabel);
			this.infoGroup.Controls.Add(this.authorLabel);
			this.infoGroup.Location = new System.Drawing.Point(9, 109);
			this.infoGroup.Margin = new System.Windows.Forms.Padding(0);
			this.infoGroup.Name = "infoGroup";
			this.infoGroup.Size = new System.Drawing.Size(256, 173);
			this.infoGroup.TabIndex = 34;
			this.infoGroup.TabStop = false;
			this.infoGroup.Text = "Info";
			// 
			// updatesLink
			// 
			this.updatesLink.AutoSize = true;
			this.updatesLink.Location = new System.Drawing.Point(6, 71);
			this.updatesLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.updatesLink.Name = "updatesLink";
			this.updatesLink.Size = new System.Drawing.Size(94, 13);
			this.updatesLink.TabIndex = 35;
			this.updatesLink.TabStop = true;
			this.updatesLink.Text = "Check for updates";
			this.updatesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatesLink_LinkClicked);
			// 
			// issuesLink
			// 
			this.issuesLink.AutoSize = true;
			this.issuesLink.Location = new System.Drawing.Point(143, 26);
			this.issuesLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.issuesLink.Name = "issuesLink";
			this.issuesLink.Size = new System.Drawing.Size(37, 13);
			this.issuesLink.TabIndex = 34;
			this.issuesLink.TabStop = true;
			this.issuesLink.Text = "Issues";
			this.issuesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLink_LinkClicked);
			// 
			// pagesGroup
			// 
			this.pagesGroup.Controls.Add(this.developerLink);
			this.pagesGroup.Controls.Add(this.projectLink);
			this.pagesGroup.Controls.Add(this.issuesLink);
			this.pagesGroup.Location = new System.Drawing.Point(9, 292);
			this.pagesGroup.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pagesGroup.Name = "pagesGroup";
			this.pagesGroup.Size = new System.Drawing.Size(256, 58);
			this.pagesGroup.TabIndex = 37;
			this.pagesGroup.TabStop = false;
			this.pagesGroup.Text = "Links";
			// 
			// AboutForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 389);
			this.Controls.Add(this.pagesGroup);
			this.Controls.Add(this.infoGroup);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.infoGroup.ResumeLayout(false);
			this.infoGroup.PerformLayout();
			this.pagesGroup.ResumeLayout(false);
			this.pagesGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label productLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label companyLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.LinkLabel developerLink;
		private System.Windows.Forms.LinkLabel projectLink;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.GroupBox infoGroup;
		private System.Windows.Forms.LinkLabel issuesLink;
		private System.Windows.Forms.LinkLabel updatesLink;
		private System.Windows.Forms.GroupBox pagesGroup;
	}
}
