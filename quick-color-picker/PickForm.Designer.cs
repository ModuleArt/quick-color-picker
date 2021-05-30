
namespace quick_color_picker
{
	partial class PickForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickForm));
			this.pickTimer = new System.Windows.Forms.Timer(this.components);
			this.pickBox = new System.Windows.Forms.PictureBox();
			this.colorPanel = new System.Windows.Forms.Panel();
			this.colorLabel = new System.Windows.Forms.Label();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pickColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hotkeyLabel = new System.Windows.Forms.Label();
			this.posLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pickBox)).BeginInit();
			this.trayContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// pickTimer
			// 
			this.pickTimer.Enabled = true;
			this.pickTimer.Interval = 25;
			this.pickTimer.Tick += new System.EventHandler(this.pickTimer_Tick);
			// 
			// pickBox
			// 
			this.pickBox.Location = new System.Drawing.Point(5, 25);
			this.pickBox.Margin = new System.Windows.Forms.Padding(0);
			this.pickBox.Name = "pickBox";
			this.pickBox.Size = new System.Drawing.Size(90, 90);
			this.pickBox.TabIndex = 0;
			this.pickBox.TabStop = false;
			// 
			// colorPanel
			// 
			this.colorPanel.Location = new System.Drawing.Point(5, 120);
			this.colorPanel.Margin = new System.Windows.Forms.Padding(0);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(20, 20);
			this.colorPanel.TabIndex = 1;
			// 
			// colorLabel
			// 
			this.colorLabel.ForeColor = System.Drawing.Color.White;
			this.colorLabel.Location = new System.Drawing.Point(25, 120);
			this.colorLabel.Margin = new System.Windows.Forms.Padding(0);
			this.colorLabel.Name = "colorLabel";
			this.colorLabel.Size = new System.Drawing.Size(70, 20);
			this.colorLabel.TabIndex = 2;
			this.colorLabel.Text = "#000000";
			this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.trayContext;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "Quick Color Picker";
			this.trayIcon.Visible = true;
			// 
			// trayContext
			// 
			this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickColorToolStripMenuItem,
            this.saveColorToolStripMenuItem,
            this.copyColorToolStripMenuItem});
			this.trayContext.Name = "trayContext";
			this.trayContext.Size = new System.Drawing.Size(171, 70);
			// 
			// pickColorToolStripMenuItem
			// 
			this.pickColorToolStripMenuItem.Name = "pickColorToolStripMenuItem";
			this.pickColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.pickColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.pickColorToolStripMenuItem.Text = "Pick color";
			// 
			// saveColorToolStripMenuItem
			// 
			this.saveColorToolStripMenuItem.Name = "saveColorToolStripMenuItem";
			this.saveColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.saveColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.saveColorToolStripMenuItem.Text = "Save color";
			// 
			// copyColorToolStripMenuItem
			// 
			this.copyColorToolStripMenuItem.Name = "copyColorToolStripMenuItem";
			this.copyColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
			this.copyColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.copyColorToolStripMenuItem.Text = "Copy color";
			// 
			// hotkeyLabel
			// 
			this.hotkeyLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.hotkeyLabel.ForeColor = System.Drawing.Color.White;
			this.hotkeyLabel.Location = new System.Drawing.Point(5, 140);
			this.hotkeyLabel.Margin = new System.Windows.Forms.Padding(0);
			this.hotkeyLabel.Name = "hotkeyLabel";
			this.hotkeyLabel.Size = new System.Drawing.Size(90, 15);
			this.hotkeyLabel.TabIndex = 3;
			this.hotkeyLabel.Text = "Alt+X";
			this.hotkeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// posLabel
			// 
			this.posLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.posLabel.ForeColor = System.Drawing.Color.White;
			this.posLabel.Location = new System.Drawing.Point(5, 5);
			this.posLabel.Margin = new System.Windows.Forms.Padding(0);
			this.posLabel.Name = "posLabel";
			this.posLabel.Size = new System.Drawing.Size(90, 15);
			this.posLabel.TabIndex = 4;
			this.posLabel.Text = "X: 0 Y: 0";
			this.posLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PickForm
			// 
			this.AlternativeAppearance = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(100, 160);
			this.Controls.Add(this.posLabel);
			this.Controls.Add(this.hotkeyLabel);
			this.Controls.Add(this.colorLabel);
			this.Controls.Add(this.colorPanel);
			this.Controls.Add(this.pickBox);
			this.DarkMode = true;
			this.EscToClose = true;
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(100, 160);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(100, 160);
			this.Name = "PickForm";
			this.ShowInTaskbar = false;
			this.Text = "Quick Color Picker";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Blue;
			((System.ComponentModel.ISupportInitialize)(this.pickBox)).EndInit();
			this.trayContext.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer pickTimer;
		private System.Windows.Forms.PictureBox pickBox;
		private System.Windows.Forms.Panel colorPanel;
		private System.Windows.Forms.Label colorLabel;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayContext;
		private System.Windows.Forms.ToolStripMenuItem pickColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveColorToolStripMenuItem;
		private System.Windows.Forms.Label hotkeyLabel;
		private System.Windows.Forms.Label posLabel;
	}
}

