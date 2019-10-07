using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace WS281x.Native
{
	internal class PInvoke
	{
		[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
		[DllImport("ws2811.so")]
		public static extern ws2811_return_t ws2811_init(IntPtr ws2811);

		[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
		[DllImport("ws2811.so")]
		public static extern ws2811_return_t ws2811_render(IntPtr ws2811);

		[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
		[DllImport("ws2811.so")]
		public static extern ws2811_return_t ws2811_wait(IntPtr ws2811);

		[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
		[DllImport("ws2811.so")]
		public static extern void ws2811_fini(IntPtr ws2811);

		[SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
		[DllImport("ws2811.so")]
		public static extern IntPtr ws2811_get_return_t_str(int state);
	}
}
