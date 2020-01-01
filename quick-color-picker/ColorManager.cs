using System;
using System.Drawing;

namespace quick_color_picker
{
	public static class ColorManager
	{
		public static int[] ColorToHSV(Color color)
		{
			int max = Math.Max(color.R, Math.Max(color.G, color.B));
			int min = Math.Min(color.R, Math.Min(color.G, color.B));

			double hue = color.GetHue();
			double saturation = (max == 0) ? 0 : 1d - (1d * min / max);
			double value = max / 255d;

			int h = Convert.ToInt32(hue);
			int s = Convert.ToInt32(saturation * 100);
			int v = Convert.ToInt32(value * 100);

			return new int[] { h, s, v };
		}

		public static int[] ColorToHSL(Color color)
		{
			float hue = color.GetHue();
			float saturation = color.GetSaturation();
			float lightness = color.GetBrightness();

			int intHue = Convert.ToInt32(hue);
			int intSaturation = Convert.ToInt32(saturation * 100);
			int intLightness = Convert.ToInt32(lightness * 100);

			return new int[] { intHue, intSaturation, intLightness };
		}

		public static int[] ColorToCMYK(Color color)
		{
			double c, m, y, k;
			double r = color.R, g = color.G, b = color.B;
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

		public static Color TextToColor(string text)
		{
			string[] strArr = text.Split(',');
			int[] arr = Array.ConvertAll(strArr, s => int.Parse(s));
			return Color.FromArgb(arr[0], arr[1], arr[2]);
		}
	}
}
