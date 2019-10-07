using System;
using System.Collections.Generic;
using System.Text;

namespace WS281x
{
	/// <summary>
	/// The type of the LED strip defines the ordering of the colors (e. g. RGB, GRB, ...).
	/// Maybe the RGBValue property of the LED class needs to be changed if there are other strip types.
	/// </summary>
	public enum StripType
	{
		/// <summary>
		/// Unknown / unset.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// SK6812_STRIP_RGBW
		/// </summary>
		SK6812_STRIP_RGBW = 0x18100800,

		/// <summary>
		/// SK6812_STRIP_RBGW
		/// </summary>
		SK6812_STRIP_RBGW = 0x18100008,

		/// <summary>
		/// SK6812_STRIP_GRBW
		/// </summary>
		SK6812_STRIP_GRBW = 0x18081000,

		/// <summary>
		/// SK6812_STRIP_GBRW
		/// </summary>
		SK6812_STRIP_GBRW = 0x18080010,

		/// <summary>
		/// SK6812_STRIP_BRGW
		/// </summary>
		SK6812_STRIP_BRGW = 0x18001008,

		/// <summary>
		/// SK6812_STRIP_BGRW
		/// </summary>
		SK6812_STRIP_BGRW = 0x18000810,

		/// <summary>
		/// WS2811_STRIP_RGB
		/// </summary>
		WS2811_STRIP_RGB = 0x00100800,

		/// <summary>
		/// WS2811_STRIP_RBG
		/// </summary>
		WS2811_STRIP_RBG = 0x00100008,

		/// <summary>
		/// WS2811_STRIP_GRB
		/// </summary>
		WS2811_STRIP_GRB = 0x00081000,

		/// <summary>
		/// WS2811_STRIP_GBR
		/// </summary>
		WS2811_STRIP_GBR = 0x00080010,

		/// <summary>
		/// WS2811_STRIP_BRG
		/// </summary>
		WS2811_STRIP_BRG = 0x00001008,

		/// <summary>
		/// WS2811_STRIP_BGR
		/// </summary>
		WS2811_STRIP_BGR = 0x00000810,
	}
}
