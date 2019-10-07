using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace rpi_ws281x.Native
{
	[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
	[StructLayout(LayoutKind.Sequential)]
	internal class ws2811_t
	{
		public long render_wait_time;
		public IntPtr device;
		public IntPtr rpi_hw;
		public uint freq;
		public int dmanum;
		public ws2811_channel_t channel_1;
		public ws2811_channel_t channel_2;
	}
}
