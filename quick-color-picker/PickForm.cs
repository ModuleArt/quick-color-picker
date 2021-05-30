using QuickLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace quick_color_picker
{
	public partial class PickForm : QlibFixedForm
	{
		private Pen aimPen = new Pen(Color.Red, 1);
		private Color aimColor;
		private Point lastMousePos;

		public PickForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			NativeMan.RegisterHotKey(Handle, 0, NativeMan.KeyModifier.Alt, Keys.X.GetHashCode());
			NativeMan.RegisterHotKey(Handle, 1, NativeMan.KeyModifier.Alt, Keys.C.GetHashCode());
			base.OnLoad(e);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			NativeMan.UnregisterHotKey(Handle, 0);
			base.OnClosing(e);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0312)
			{
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				NativeMan.KeyModifier modifier = (NativeMan.KeyModifier)((int)m.LParam & 0xFFFF);

				if (modifier == NativeMan.KeyModifier.Alt)
				{
					if (key == Keys.X) PickColor();
					else if (key == Keys.C) CopyColor();
					else if (key == Keys.S) SaveColor();
				}
			}
		}

		private void PickColor()
		{

		}

		private void CopyColor()
		{

		}

		private void SaveColor()
		{

		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
		}

		private void pickTimer_Tick(object sender, EventArgs e)
		{
			//if (lastMousePos != Cursor.Position)
			//{
				Screen curScreen = Screen.FromPoint(Cursor.Position);
				Point screenPos = curScreen.Bounds.Location;
				Location = new Point(
					Cursor.Position.X - Width / 2,
					Cursor.Position.Y < Height + 30 + screenPos.Y ? Cursor.Position.Y + 30 : Cursor.Position.Y - Height - 20
				);
				lastMousePos = Cursor.Position;

				try
				{
					Bitmap bmp = new Bitmap(pickBox.Width, pickBox.Height);
					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
						g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
						g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
						g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

						g.CopyFromScreen(
							Cursor.Position.X - pickBox.Width / 6,
							Cursor.Position.Y - pickBox.Height / 6,
							0, 0,
							new Size(pickBox.Width / 3, pickBox.Height / 3)
						);

						Bitmap scaledBmp = new Bitmap(bmp, pickBox.Width, pickBox.Height);
						g.Clear(Color.Black);
						g.DrawImage(scaledBmp, 0, 0, pickBox.Width * 3, pickBox.Height * 3);
						scaledBmp.Dispose();

						if (pickBox.Image != null) pickBox.Image.Dispose();
						pickBox.Image = bmp;

						aimColor = bmp.GetPixel(pickBox.Width / 2, pickBox.Height / 2);

						g.DrawLine(aimPen, 0, pickBox.Height / 2, pickBox.Width, pickBox.Height / 2);
						g.DrawLine(aimPen, pickBox.Width / 2, 0, pickBox.Height / 2, pickBox.Height);
					}

					colorPanel.BackColor = aimColor;
					colorLabel.Text = ColorMan.ToHexStr(aimColor);
					posLabel.Text = "X: " + Cursor.Position.X + " Y: " + Cursor.Position.Y;
				}
				catch
				{

				}
				
				if (!trayContext.Visible) BringToFront();
			//}
		}
	}
}
