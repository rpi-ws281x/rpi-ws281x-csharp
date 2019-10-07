using System.Diagnostics.CodeAnalysis;

namespace rpi_ws281x.Native
{
    [SuppressMessage("IDE1006", "IDE1006", Justification = "Native methods have different naming conventions.")]
	internal enum ws2811_return_t
	{
		WS2811_SUCCESS = 0,
		WS2811_ERROR_GENERIC = -1,
		WS2811_ERROR_OUT_OF_MEMORY = -2,
		WS2811_ERROR_HW_NOT_SUPPORTED = -3,
		WS2811_ERROR_MEM_LOCK = -4,
		WS2811_ERROR_MMAP = -5,
		WS2811_ERROR_MAP_REGISTERS = -6,
		WS2811_ERROR_GPIO_INIT = -7,
		WS2811_ERROR_PWM_SETUP = -8,
		WS2811_ERROR_MAILBOX_DEVICE = -9,
		WS2811_ERROR_DMA = -10,
		WS2811_ERROR_ILLEGAL_GPIO = -11,
		WS2811_ERROR_PCM_SETUP = -12,
		WS2811_ERROR_SPI_SETUP = -13,
		WS2811_ERROR_SPI_TRANSFER = -14
	}
}
