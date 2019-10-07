using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WS281x.Native
{
	[StructLayout(LayoutKind.Sequential)]
	[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
	internal struct ws2811_channel_t
	{
		public int gpionum;
		public int invert;
		public int count;
		public int strip_type;
		public IntPtr leds;
		public byte brightness;
		public byte wshift;
		public byte rshift;
		public byte gshift;
		public byte bshift;
		public IntPtr gamma;
	}
}
