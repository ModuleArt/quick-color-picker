using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quick_color_picker
{
	partial class AboutForm : Form
	{
		public AboutForm(bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();

			string fullVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			int lastDotIndex = fullVer.LastIndexOf('.');
			versionLabel.Text = String.Format("Version: {0}", fullVer.Substring(0, lastDotIndex));

			if (IntPtr.Size == 4)
			{
				versionLabel.Text += " (x32)";
			}
			else if (IntPtr.Size == 8)
			{
				versionLabel.Text += " (x64)";
			}

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				infoGroup.Paint += ThemeManager.PaintDarkGroupBox;
				pagesGroup.Paint += ThemeManager.PaintDarkGroupBox;

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
			this.Close();
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
