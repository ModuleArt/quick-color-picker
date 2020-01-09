using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quick_color_picker
{
	partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();

			versionLabel.Text = String.Format("Version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0, 5));

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				infoGroup.ForeColor = Color.White;
				pagesGroup.ForeColor = Color.White;

				Color linkColor = ThemeManager.AccentColorDark;

				updatesLink.LinkColor = linkColor;
				developerLink.LinkColor = linkColor;
				projectLink.LinkColor = linkColor;
				issuesLink.LinkColor = linkColor;
				licenseLink.LinkColor = linkColor;

				okButton.BackColor = ThemeManager.SecondColorDark;
			}
		}

		private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://moduleart.github.io/");
		}

		private void projectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-color-picker/");
		}

		private void issuesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-color-picker/issues/");
		}

		private void updatesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm parent = (MainForm)this.Owner;

			parent.checkForUpdates(true);
		}

		private void AboutForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-color-picker/blob/master/LICENSE.md/");
		}
	}
}
