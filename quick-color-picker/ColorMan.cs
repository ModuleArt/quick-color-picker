using System.Drawing;

namespace quick_color_picker
{
	public static class ColorMan
	{
		public static string ToHexStr(Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";
	}
}
