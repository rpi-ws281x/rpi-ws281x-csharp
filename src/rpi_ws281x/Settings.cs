using System.Collections.Generic;
using System.Collections.ObjectModel;
using rpi_ws281x.Native;

namespace rpi_ws281x
{
	/// <summary>
	/// Settings which are required to initialize the WS281x controller
	/// </summary>
	public class Settings
	{

        /// <summary>
        /// Settings to initialize the WS281x controller with one channel
        /// </summary>
        /// <param name="frequency">Set frequency in Hz</param>
        /// <param name="dmaChannel">Set DMA channel to use</param>
        public Settings(Channel channel, uint frequency = 800000, int dmaChannel = 10) : this (channel, null, frequency, dmaChannel) { }

        /// <summary>
        /// Settings to initialize the WS281x controller with up to two channels
        /// </summary>
        /// <param name="frequency">Set frequency in Hz</param>
        /// <param name="dmaChannel">Set DMA channel to use</param>
        public Settings(Channel channel1, Channel channel2, uint frequency = 800000, int dmaChannel = 10)
        {
            Channel_1 = channel1;
            if (channel2 == null)
                ChannelCount = 1;
            else {
                Channel_2 = channel2;
                ChannelCount = 2;
            }
            Frequency = frequency;
            DMAChannel = dmaChannel;
        }

        /// <summary>
		/// Returns default settings.
		/// Use a frequency of 800000 Hz and DMA channel 10
		/// </summary>
		/// <returns></returns>
		public static Settings CreateDefaultSettings()
        {
            return new Settings(null, 800000, 10);
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
        /// Returns the number of channels being used
        /// </summary>
        public int ChannelCount { get; private set; }

		/// <summary>
		/// Returns Channel 1
		/// </summary>
		public Channel Channel_1 { get; set; }

        /// <summary>
		/// Returns Channel 1
		/// </summary>
		public Channel Channel_2 { get; set; }
    }
}
