using System.Windows.Forms;

namespace quick_color_picker
{
	public class ToolStripOverride : ToolStripSystemRenderer
	{
		public ToolStripOverride() { }

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
	}
}
