using System;
using System.Runtime.InteropServices;

namespace Native
{
	internal class PInvoke
	{
		public const int RPI_PWM_CHANNELS = 2;

		[DllImport("ws2811.so")]
		public static extern ws2811_return_t ws2811_init(ref ws2811_t ws2811);
		
		[DllImport("ws2811.so")]
		public static extern ws2811_return_t ws2811_render(ref ws2811_t ws2811);

		[DllImport("ws2811.so")]
		public static extern ws2811_return_t ws2811_wait(ref ws2811_t ws2811);
		
		[DllImport("ws2811.so")]
		public static extern void ws2811_fini(ref ws2811_t ws2811);

		[DllImport("ws2811.so")]
		public static extern IntPtr ws2811_get_return_t_str(int state);
	}
}
