using System.Collections.Generic;
using System.Collections.ObjectModel;
using WS281x.Native;

namespace WS281x
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
        public Settings(Channel channel, uint frequency = 800000, int dmaChannel = 10)
		{
            Channel = channel;
			Frequency = frequency;
			DMAChannel = dmaChannel;
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
		public Channel Channel { get; set; }
	}
}
