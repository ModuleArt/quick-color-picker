using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_color_picker
{
	public partial class MainForm : Form
	{
		private Pen aimPen = new Pen(Color.Red, 1);
		private Color aimColor;
		private bool alwaysOnTop = true;
		private bool anotherFormat = false;
		private bool darkMode;
		private List<string> colors = new List<string>();

		private enum KeyModifier
		{
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
			WinKey = 8
		}

		public MainForm(bool darkMode)
		{
			this.darkMode = darkMode;

			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();

			copyTooltip.SetToolTip(rgbCopyButton, "Copy value");
			copyTooltip.SetToolTip(htmlCopyButton, "Copy value");
			copyTooltip.SetToolTip(cmykCopyButton, "Copy value");
			copyTooltip.SetToolTip(hslCopyButton, "Copy value");
			copyTooltip.SetToolTip(rgbOneCopyButton, "Copy value");
			copyTooltip.SetToolTip(hsvCopyButton, "Copy value");
			copyTooltip.SetToolTip(renameButton, "Rename selected color");

			toolStrip1.Renderer = new ToolStripOverride();

			renameTextBox.AutoSize = false;
			renameTextBox.Height = 20;

			if (darkMode)
			{
				applyDarkTheme();
			}
		}

		private void CaptureScreen()
		{
			try
			{
				Bitmap bmp = new Bitmap(120, 120);
				using (Graphics g = Graphics.FromImage(bmp))
				{
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
					g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

					g.CopyFromScreen(
						Cursor.Position.X - 20,
						Cursor.Position.Y - 20, 0, 0,
						new Size(40, 40)
					);

					Bitmap scaledBmp = new Bitmap(bmp, 120, 120);

					g.Clear(Color.Black);
					g.DrawImage(scaledBmp, 0, 0, 360, 360);

					scaledBmp.Dispose();

					if (aimPictureBox.Image != null) aimPictureBox.Image.Dispose();

					aimPictureBox.Image = bmp;

					aimColor = bmp.GetPixel(aimPictureBox.Width / 2, aimPictureBox.Height / 2);
					colorPanel.BackColor = aimColor;

					g.DrawLine(aimPen, 0, aimPictureBox.Height / 2, aimPictureBox.Width, aimPictureBox.Height / 2);
					g.DrawLine(aimPen, aimPictureBox.Width / 2, 0, aimPictureBox.Height / 2, aimPictureBox.Height);
				}

				xLabel.Invoke((MethodInvoker)(() => xLabel.Text = "X: " + Cursor.Position.X));
				yLabel.Invoke((MethodInvoker)(() => yLabel.Text = "Y: " + Cursor.Position.Y));

				rgbStatusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => rgbStatusLabel.Text = "RGB: " + aimColor.R + ", " + aimColor.G + ", " + aimColor.B));
				hexStatusLabel.GetCurrentParent().Invoke((MethodInvoker)(() => hexStatusLabel.Text = "HEX: " + ColorTranslator.ToHtml(aimColor).ToString()));
			
				this.Invoke((MethodInvoker)(() => this.Text = aimColor.R + ", " + aimColor.G + ", " + aimColor.B + " - Quick Color Picker"));
			}
			catch
			{

			}
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		private void MainForm_Load(object sender, EventArgs e)
		{
			RegisterHotKey(this.Handle, 0, (int) KeyModifier.Alt, Keys.X.GetHashCode());
			RegisterHotKey(this.Handle, 1, (int)KeyModifier.Alt, Keys.C.GetHashCode());

			Task task = new Task(() =>
			{
				while (true)
				{
					CaptureScreen();
					Thread.Sleep(100);
				}
			});

			task.Start();

			LoadColorList();

			checkForUpdates(false);

			setAlwaysOnTop(Properties.Settings.Default.AlwaysOnTop, false);
			setAnotherFormat(Properties.Settings.Default.AnotherFormat, false);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);             
				KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);  

				if (modifier == KeyModifier.Alt)
				{
					if (key == Keys.X)
					{
						GetColor();
					}
					else if (key == Keys.C)
					{
						CopyColor();
					}
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(this.Handle, 0);
		}

		private void CopyColor()
		{
			Clipboard.SetText(this.Text = aimColor.R + ", " + aimColor.G + ", " + aimColor.B);
		}

		private void GetColor()
		{
			AddColor(aimColor);
			colorList.SetSelected(colorList.Items.Count - 1, true);
			SaveColorList();
			SaveColorNames();
		}

		private void AddColor(Color c)
		{
			colors.Add(c.R + ", " + c.G + ", " + c.B);
			colorList.Items.Add(c.R + ", " + c.G + ", " + c.B);
		}

		private void AddColor(string color, string name)
		{
			try
			{
				ColorManager.TextToColor(color);
				colors.Add(color);
				colorList.Items.Add(name);
			}
			catch
			{

			}
		}

		private void colorList_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index != -1)
			{
				e.DrawBackground();

				int itemIndex = e.Index;
				string itemText = colorList.Items[itemIndex].ToString();
				string colorText = colors[itemIndex]; ;

				if (itemIndex >= 0 && itemIndex < colorList.Items.Count)
				{
					Graphics g = e.Graphics;

					Color c = ColorManager.TextToColor(colorText);

					// Background color
					SolidBrush backgroundColorBrush = new SolidBrush(c);
					g.FillRectangle(backgroundColorBrush, e.Bounds);

					// Item text
					SolidBrush itemTextColorBrush;
					if (c.GetBrightness() > 0.5) { 
						itemTextColorBrush = new SolidBrush(Color.Black);
					} 
					else
					{
						itemTextColorBrush = new SolidBrush(Color.White);
					}
					if (e.Index == colorList.SelectedIndex)
					{
						Font f = new Font(e.Font, FontStyle.Bold);
						Point p = new Point(
							colorList.GetItemRectangle(itemIndex).Location.X + 10, 
							colorList.GetItemRectangle(itemIndex).Location.Y
						);

						g.DrawString(itemText, f, itemTextColorBrush, p);
					}
					else
					{
						g.DrawString(itemText, e.Font, itemTextColorBrush, colorList.GetItemRectangle(itemIndex).Location);
					}

					// Clean up
					backgroundColorBrush.Dispose();
					itemTextColorBrush.Dispose();
				}
			}
		}

		private void colorList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (colorList.SelectedIndex != -1)
			{
				deleteButton.Enabled = true;
				renameButton.Enabled = true;
				renameTextBox.Enabled = true;
				renameTextBox.Text = colorList.Items[colorList.SelectedIndex].ToString();

				string t = colors[colorList.SelectedIndex];
				Color c = ColorManager.TextToColor(t);

				string htmlText = ColorTranslator.ToHtml(c).ToString();
				int[] cmyk = ColorManager.ColorToCMYK(c);
				int[] hsl = ColorManager.ColorToHSL(c);
				int[] hsv = ColorManager.ColorToHSV(c);

				double rOne = c.R / (double)255;
				double gOne = c.G / (double)255;
				double bOne = c.B / (double)255;

				if (anotherFormat)
				{
					rgbTextBox.Text = "rgb(" + c.R + ", " + c.G + ", " + c.B + ")";
					htmlTextBox.Text = "0x" + htmlText.Substring(1, htmlText.Length - 1);
					cmykTextBox.Text = "cmyk(" + cmyk[0] + "%, " + cmyk[1] + "%, " + cmyk[2] + "%, " + cmyk[3] + "%)";
					hslTextBox.Text = "hsl(" + hsl[0] + ", " + hsl[1] + "%, " + hsl[2] + "%)";
					rgbOneTextBox.Text = rOne.ToString("0.####") + " / " + gOne.ToString("0.####") + " / " + bOne.ToString("0.####");
					hsvTextBox.Text = hsv[0] + "°, " + hsv[1] + "%, " + hsv[2] + "%";
				}
				else
				{
					rgbTextBox.Text = t;
					htmlTextBox.Text = htmlText;
					cmykTextBox.Text = cmyk[0] + ", " + cmyk[1] + ", " + cmyk[2] + ", " + cmyk[3];
					hslTextBox.Text = hsl[0] + ", " + hsl[1] + ", " + hsl[2];
					rgbOneTextBox.Text = rOne.ToString("0.##") + "; " + gOne.ToString("0.##") + "; " + bOne.ToString("0.##");
					hsvTextBox.Text = hsv[0] + ", " + hsv[1] + ", " + hsv[2];
				}

				gradPanel.BackColor = c;
				ratioPanel.BackColor = c;

				int r1 = c.R - 50;
				int g1 = c.G - 50;
				int b1 = c.B - 50;

				if (r1 < 0 || g1 < 0 || b1 < 0)
				{
					r1 = 0;
					g1 = 0;
					b1 = 0;
				}

				gradPanel1.BackColor = Color.FromArgb(r1, g1, b1);

				int r2 = c.R - 25;
				int g2 = c.G - 25;
				int b2 = c.B - 25;

				if (r2 < 0 || g2 < 0 || b2 < 0)
				{
					r2 = 0;
					g2 = 0;
					b2 = 0;
				}

				gradPanel2.BackColor = Color.FromArgb(r2, g2, b2);

				int r3 = c.R + 25;
				int g3 = c.G + 25;
				int b3 = c.B + 25;

				if (r3 > 255 || g3 > 255 || b3 > 255)
				{
					r3 = 255;
					g3 = 255;
					b3 = 255;
				}

				gradPanel3.BackColor = Color.FromArgb(r3, g3, b3);

				int r4 = c.R + 50;
				int g4 = c.G + 50;
				int b4 = c.B + 50;

				if (r4 > 255 || g4 > 255 || b4 > 255)
				{
					r4 = 255;
					g4 = 255;
					b4 = 255;
				}

				gradPanel4.BackColor = Color.FromArgb(r4, g4, b4);

				CreateLinearGradient(gradPanel1.BackColor, gradPanel.BackColor, gradPanel4.BackColor);
			}
			else
			{
				deleteButton.Enabled = false;
				renameButton.Enabled = false;
				renameTextBox.Enabled = false;
				renameTextBox.Text = "";
			}

			colorList.Refresh();
		}

		private void rgbCopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rgbTextBox.Text);
		}

		private void htmlCopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(htmlTextBox.Text);
		}

		private void cmykCopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(cmykTextBox.Text);
		}

		private void applyDarkTheme()
		{
			ThemeManager.setDarkModeToControl(colorList.Handle);

			this.BackColor = ThemeManager.BackColorDark;
			this.ForeColor = Color.White;
			toolStrip1.BackColor = ThemeManager.BackColorDark;
			colorList.BackColor = ThemeManager.SecondColorDark;
			statusStrip1.BackColor = ThemeManager.SecondColorDark;

			rgbTextBox.BackColor = ThemeManager.SecondColorDark;
			rgbTextBox.ForeColor = Color.White;

			htmlTextBox.BackColor = ThemeManager.SecondColorDark;
			htmlTextBox.ForeColor = Color.White;

			cmykTextBox.BackColor = ThemeManager.SecondColorDark;
			cmykTextBox.ForeColor = Color.White;

			hslTextBox.BackColor = ThemeManager.SecondColorDark;
			hslTextBox.ForeColor = Color.White;

			rgbOneTextBox.BackColor = ThemeManager.SecondColorDark;
			rgbOneTextBox.ForeColor = Color.White;

			hsvTextBox.BackColor = ThemeManager.SecondColorDark;
			hsvTextBox.ForeColor = Color.White;

			rgbCopyButton.Image = Properties.Resources.white_copy;
			htmlCopyButton.Image = Properties.Resources.white_copy;
			cmykCopyButton.Image = Properties.Resources.white_copy;
			hslCopyButton.Image = Properties.Resources.white_copy;
			rgbOneCopyButton.Image = Properties.Resources.white_copy;
			hsvCopyButton.Image = Properties.Resources.white_copy;

			onTopButton.Image = Properties.Resources.white_ontop;
			clearListButton.Image = Properties.Resources.white_broom;
			deleteButton.Image = Properties.Resources.white_trash;
			formatButton.Image = Properties.Resources.white_format;
			aboutButton.Image = Properties.Resources.white_about;

			renameTextBox.BackColor = ThemeManager.SecondColorDark;
			renameTextBox.ForeColor = Color.White;
			renameButton.Image = Properties.Resources.white_rename;
		}

		private void hslCopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(hslTextBox.Text);
		}

		private void rgbOneCopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rgbOneTextBox.Text);
		}

		private void onTopButton_Click(object sender, EventArgs e)
		{
			setAlwaysOnTop(!alwaysOnTop, true);
		}

		private void setAlwaysOnTop(bool b, bool saveToDisk)
		{
			alwaysOnTop = b;
			this.TopMost = b;
			onTopButton.Checked = b;

			if (saveToDisk)
			{
				Properties.Settings.Default.AlwaysOnTop = b;
				Properties.Settings.Default.Save();
			}
		}

		private void setAnotherFormat(bool b, bool saveToDisk)
		{
			anotherFormat = b;
			formatButton.Checked = b;

			if (colorList.SelectedIndex != -1)
			{
				colorList.SetSelected(colorList.SelectedIndex, true);
			}

			if (saveToDisk)
			{
				Properties.Settings.Default.AnotherFormat = b;
				Properties.Settings.Default.Save();
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.KeyCode == Keys.T)
				{
					onTopButton.PerformClick();
				}
				else if (e.KeyCode == Keys.L)
				{
					clearListButton.PerformClick();
				}
				else if (e.KeyCode == Keys.F)
				{
					formatButton.PerformClick();
				}
			} 
			else
			{
				if (e.KeyCode == Keys.Delete)
				{
					deleteButton.PerformClick();
				}
				else if (e.KeyCode == Keys.F1)
				{
					aboutButton.PerformClick();
				}
			}
		}

		private void clearListButton_Click(object sender, EventArgs e)
		{
			colors.Clear();
			colorList.Items.Clear();
			SaveColorList();
			SaveColorNames();
			deleteButton.Enabled = false;
			renameButton.Enabled = false;
			renameTextBox.Enabled = false;
			renameTextBox.Text = "";
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (colorList.SelectedIndex != -1)
			{
				int curIndex = colorList.SelectedIndex;
				colorList.Items.RemoveAt(curIndex);
				colors.RemoveAt(curIndex);

				if (colorList.Items.Count > 0)
				{
					if (colorList.Items.Count - 1 >= curIndex)
					{
						colorList.SetSelected(curIndex, true);
					}
					else if (colorList.Items.Count >= curIndex)
					{
						colorList.SetSelected(curIndex - 1, true);
					}
				}

				SaveColorList();
				SaveColorNames();
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm(darkMode);
			aboutBox.Owner = this;
			if (alwaysOnTop)
			{
				aboutBox.TopMost = true;
			}
			aboutBox.FormClosed += aboutBox_FormClosed;
			aboutBox.ShowDialog();
		}

		private void aboutBox_FormClosed(object sender, EventArgs e)
		{
			AboutForm aboutBox = sender as AboutForm;
			aboutBox.Dispose();
			aboutBox = null;
		}

		public async void checkForUpdates(bool showUpToDateDialog)
		{
			try
			{
				UpdateChecker checker = new UpdateChecker("ModuleArt", "quick-color-picker");

				bool update = await checker.CheckUpdate();

				if (update == false)
				{
					if (showUpToDateDialog)
					{
						MessageBox.Show("Application is up to date", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					UpdateForm updateDialog = new UpdateForm(checker, "Quick Color Picker", darkMode);

					if (alwaysOnTop)
					{
						updateDialog.TopMost = true;
					}

					DialogResult result = updateDialog.ShowDialog();
					if (result == DialogResult.Yes)
					{
						DownloadForm downloadBox = new DownloadForm(checker.GetAssetUrl("QuickColorPicker-Setup.msi"), darkMode);
						downloadBox.Owner = this;
						if (alwaysOnTop)
						{
							downloadBox.TopMost = true;
						}
						downloadBox.ShowDialog();
					}
					else
					{
						updateDialog.Dispose();
					}
				}
			}
			catch
			{
				if (showUpToDateDialog)
				{
					MessageBox.Show("Connection error", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void SaveColorList()
		{
			try
			{
				string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quick Color Picker");
				DirectoryInfo di = new DirectoryInfo(appDataFolder);

				if (!di.Exists)
				{
					di.Create();
				}

				string colorListPath = Path.Combine(appDataFolder, "color-list.txt");
				FileInfo fiColors = new FileInfo(colorListPath);

				using (StreamWriter sw = fiColors.CreateText())
				{
					string[] linesToWrite = new string[colors.Count];
					for (int i = 0; i < colors.Count; i++)
					{
						sw.WriteLine(colors[i].ToString());
					}
				}
			}
			catch
			{

			}
		}

		private void SaveColorNames()
		{
			try
			{
				string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Quick Color Picker");
				DirectoryInfo di = new DirectoryInfo(appDataFolder);

				if (!di.Exists)
				{
					di.Create();
				}

				string colorNamesPath = Path.Combine(appDataFolder, "color-names.txt");
				FileInfo fiNames = new FileInfo(colorNamesPath);

				using (StreamWriter sw = fiNames.CreateText())
				{
					string[] linesToWrite = new string[colorList.Items.Count];
					for (int i = 0; i < colorList.Items.Count; i++)
					{
						sw.WriteLine(colorList.Items[i].ToString());
					}
				}
			}
			catch 
			{

			}
		}

		private void LoadColorList()
		{
			try
			{
				string colorListTxt = Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
					"Quick Color Picker",
					"color-list.txt"
				);

				string colorNamesTxt = Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
					"Quick Color Picker",
					"color-names.txt"
				);

				string[] colorsLines = File.ReadAllLines(colorListTxt);
				string[] namesLines = File.ReadAllLines(colorNamesTxt);

				for (int i = 0; i < colorsLines.Length; i++)
				{
					try
					{
						AddColor(colorsLines[i], namesLines[i]);
					}
					catch
					{

					}
				}

				colorList.SetSelected(colorList.Items.Count - 1, true);
			}
			catch
			{

			}
		}

		private void gradPanel_Click(object sender, EventArgs e)
		{
			AddColor((sender as Panel).BackColor);
		}

		private void formatButton_Click(object sender, EventArgs e)
		{
			setAnotherFormat(!anotherFormat, true);
		}

		private void hsvCopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(hsvTextBox.Text);
		}

		private void renameButton_Click(object sender, EventArgs e)
		{
			if (colorList.SelectedIndex != -1)
			{
				colorList.Items[colorList.SelectedIndex] = renameTextBox.Text;
				colorList.Items[colorList.SelectedIndex] = colorList.Items[colorList.SelectedIndex];
			}
			SaveColorNames();
		}

		private void renameTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				renameButton.PerformClick();
			}
		}

		private void CreateLinearGradient(Color from, Color middle, Color to)
		{
			Bitmap bmp = new Bitmap(linearGradPictureBox.Width, linearGradPictureBox.Height);
			Graphics g = Graphics.FromImage(bmp);

			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
			   new Point(0, 0),
			   new Point(bmp.Width, bmp.Height),
			   from, to
			);

			ColorBlend cblend = new ColorBlend(3);
			cblend.Colors = new Color[3] { from, middle, to };
			cblend.Positions = new float[3] { 0f, 0.5f, 1f };

			linearGradientBrush.InterpolationColors = cblend;

			g.FillRectangle(linearGradientBrush, 0, 0, bmp.Width, bmp.Height);

			linearGradPictureBox.Image = bmp;
		}

		private void linearGradPictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			Bitmap b = new Bitmap(linearGradPictureBox.ClientSize.Width, linearGradPictureBox.Height);
			linearGradPictureBox.DrawToBitmap(b, linearGradPictureBox.ClientRectangle);
			Color colour = b.GetPixel(e.Location.X, e.Location.Y);

			AddColor(colour);
		}
	}
}
