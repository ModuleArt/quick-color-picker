using GitHubUpdate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_color_picker
{
	public partial class MainForm : Form
	{
		private Pen aimPen = new Pen(Color.Red, 1);
		private Color aimColor;
		private bool darkMode = false;
		private bool alwaysOnTop = true;
		private bool anotherFormat = false;

		public MainForm()
		{
			InitializeComponent();
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

					if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

					pictureBox1.Image = bmp;

					aimColor = bmp.GetPixel(pictureBox1.Width / 2, pictureBox1.Height / 2);
					colorPanel.BackColor = aimColor;

					g.DrawLine(aimPen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
					g.DrawLine(aimPen, pictureBox1.Width / 2, 0, pictureBox1.Height / 2, pictureBox1.Height);
				}

				xLabel.Invoke((MethodInvoker)(() => xLabel.Text = "X: " + Cursor.Position.X));
				yLabel.Invoke((MethodInvoker)(() => yLabel.Text = "Y: " + Cursor.Position.Y));
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

			toolStrip1.Renderer = new ToolStripOverride();

			darkMode = ThemeManager.isDarkTheme();
			if (darkMode)
			{
				applyDarkTheme();
			}

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
		}

		enum KeyModifier
		{
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
			WinKey = 8
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);             
				KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);  
				int id = m.WParam.ToInt32();

				GetColor();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(this.Handle, 0);
		}

		private void GetColor()
		{
			AddColor(aimColor);
			colorList.SetSelected(colorList.Items.Count - 1, true);
			SaveColorList();
		}

		private void AddColor(Color c)
		{
			colorList.Items.Add(c.R + ", " + c.G + ", " + c.B);
		}

		private void AddColor(string s)
		{
			try
			{
				textToColor(s);
				colorList.Items.Add(s);
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

				if (itemIndex >= 0 && itemIndex < colorList.Items.Count)
				{
					Graphics g = e.Graphics;

					Color c = textToColor(itemText);

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

				string t = colorList.Items[colorList.SelectedIndex].ToString();
				Color c = textToColor(t);

				string htmlText = ColorTranslator.ToHtml(c).ToString();
				int[] cmyk = RgbToCmyk(c.R, c.G, c.B);
				int[] hsl = ColorToHsl(c);

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
				}
				else
				{
					rgbTextBox.Text = t;
					htmlTextBox.Text = htmlText;
					cmykTextBox.Text = cmyk[0] + ", " + cmyk[1] + ", " + cmyk[2] + ", " + cmyk[3];
					hslTextBox.Text = hsl[0] + ", " + hsl[1] + ", " + hsl[2];
					rgbOneTextBox.Text = rOne.ToString("0.##") + "; " + gOne.ToString("0.##") + "; " + bOne.ToString("0.##");
				}

				gradPanel.BackColor = c;

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
			}
			else
			{
				deleteButton.Enabled = false;
			}

			colorList.Refresh();
		}

		private Color textToColor(string text)
		{
			string[] strArr = text.Split(',');
			int[] arr = Array.ConvertAll(strArr, s => int.Parse(s));
			return Color.FromArgb(arr[0], arr[1], arr[2]);
		}

		private int[] RgbToCmyk(int intR, int intG, int intB)
		{
			double c, m, y, k;
			double r = intR, g = intG, b = intB;
			double r1 = r / 255, g1 = g / 255, b1 = b / 255;

			k = 1 - Math.Max(Math.Max(r1, g1), b1);

			if (k == 1)
			{
				return new int[] { 0, 0, 0, 1 };
			}
			else
			{
				c = (1 - r1 - k) / (1 - k);
				m = (1 - g1 - k) / (1 - k);
				y = (1 - b1 - k) / (1 - k);

				int intC = Convert.ToInt32(c * 100);
				int intM = Convert.ToInt32(m * 100);
				int intY = Convert.ToInt32(y * 100);
				int intK = Convert.ToInt32(k * 100);

				return new int[] { intC, intM, intY, intK };
			}
		}

		private int[] ColorToHsl(Color color)
		{
			float hue = color.GetHue();
			float saturation = color.GetSaturation();
			float lightness = color.GetBrightness();

			int intHue = Convert.ToInt32(hue);
			int intSaturation = Convert.ToInt32(saturation * 100);
			int intLightness = Convert.ToInt32(lightness * 100);

			return new int[] { intHue, intSaturation, intLightness }; 
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
			this.BackColor = ThemeManager.BackColorDark;
			this.ForeColor = Color.White;
			toolStrip1.BackColor = ThemeManager.BackColorDark;
			colorList.BackColor = ThemeManager.SecondColorDark;

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

			rgbCopyButton.Image = Properties.Resources.white_copy;
			htmlCopyButton.Image = Properties.Resources.white_copy;
			cmykCopyButton.Image = Properties.Resources.white_copy;
			hslCopyButton.Image = Properties.Resources.white_copy;
			rgbOneCopyButton.Image = Properties.Resources.white_copy;

			onTopButton.Image = Properties.Resources.white_ontop;
			clearListButton.Image = Properties.Resources.white_broom;
			deleteButton.Image = Properties.Resources.white_trash;
			formatButton.Image = Properties.Resources.white_format;
			aboutButton.Image = Properties.Resources.white_about;
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
			setAlwaysOnTop(!alwaysOnTop);
		}

		private void setAlwaysOnTop(bool b)
		{
			alwaysOnTop = b;
			this.TopMost = b;
			onTopButton.Checked = b;
		}

		private void setAnotherFormat(bool b)
		{
			anotherFormat = b;
			formatButton.Checked = b;

			if (colorList.SelectedIndex != -1)
			{
				colorList.SetSelected(colorList.SelectedIndex, true);
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
			colorList.Items.Clear();
			SaveColorList();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (colorList.SelectedIndex != -1)
			{
				int curIndex = colorList.SelectedIndex;
				colorList.Items.RemoveAt(curIndex);

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
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm();
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
				var checker = new UpdateChecker("ModuleArt", "quick-color-picker");

				UpdateType update = await checker.CheckUpdate();

				if (update == UpdateType.None)
				{
					if (showUpToDateDialog)
					{
						MessageBox.Show("Application is up to date", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					var result = new UpdateNotifyDialog(checker).ShowDialog();
					if (result == DialogResult.Yes)
					{
						checker.DownloadAsset("QuickColorPicker-Setup.msi");
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
				string path = "color-list.txt";

				if (!File.Exists(path))
				{
					File.Create(path);
				}

				string[] linesToWrite = new string[colorList.Items.Count];
				for (int i = 0; i < colorList.Items.Count; i++)
				{
					linesToWrite[i] = colorList.Items[i].ToString();
				}

				File.WriteAllLines(path, linesToWrite);
			}
			catch
			{

			}
		}

		private void LoadColorList()
		{
			try
			{
				string[] lines = File.ReadAllLines("color-list.txt");

				for (int i = 0; i < lines.Length; i++)
				{
					try
					{
						AddColor(lines[i]);
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
			setAnotherFormat(!anotherFormat);
		}
	}
}
