using System;
using System.Collections.Generic;
using System.Text;

namespace rpi_ws281x
{
	/// <summary>
	/// The type of the LED strip defines the ordering of the colors (e. g. RGB, GRB, ...).
	/// Maybe the RGBValue property of the LED class needs to be changed if there are other strip types.
	/// </summary>
    public enum StripType
    {
		Unknown = 0,
		WS2812_STRIP = 0x00081000
	}
}
