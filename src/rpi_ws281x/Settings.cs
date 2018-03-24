using Native;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace rpi_ws281x
{
	/// <summary>
	/// Settings which are required to initialize the WS281x controller
	/// </summary>
	public class Settings
	{
	
		/// <summary>
		/// Settings to initialize the WS281x controller
		/// </summary>
		/// <param name="frequency">Set frequency in Hz</param>
		/// <param name="dmaChannel">Set DMA channel to use</param>
		public Settings(uint frequency, int dmaChannel)
		{
			Frequency = frequency;
			DMAChannel = dmaChannel;
			Channels = new Channel[PInvoke.RPI_PWM_CHANNELS];				
		}

		/// <summary>
		/// Returns default settings.
		/// Use a frequency of 800000 Hz and DMA channel 10
		/// </summary>
		/// <returns></returns>
		public static Settings CreateDefaultSettings()
		{
			return new Settings(800000, 10);
		}

		/// <summary>
		/// Returns the used frequency in Hz
		/// </summary>
		public uint Frequency { get; private set; }

		/// <summary>
		/// Returns the DMA channel
		/// </summary>
		public int DMAChannel { get; private set; }

		/// <summary>
		/// Returns the channels which holds the LEDs
		/// </summary>
		public Channel[] Channels { get; private set; }
	}
}
