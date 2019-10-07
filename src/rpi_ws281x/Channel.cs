using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WS281x
{
	/// <summary>
	/// Represents the channel which holds the LEDs
	/// </summary>
	public class Channel
	{
		
		/// <summary>
		/// Returns the GPIO pin which is connected to the LED strip
		/// </summary>
		public int GPIOPin { get; private set; }

		/// <summary>
		/// Returns a value which indicates if the signal needs to be inverted.
		/// Set to true to invert the signal (when using NPN transistor level shift).
		/// </summary>
		public bool Invert { get; private set; }

		/// <summary>
		/// Gets or sets the brightness of the LEDs
		/// 0 = darkest, 255 = brightest
		/// </summary>
		public byte Brightness { get; set; }

		/// <summary>
		/// Returns the type of the channel.
		/// The type defines the ordering of the colors.
		/// </summary>
		public StripType StripType { get; private set; }

		/// <summary>
		/// Returns all LEDs on this channel
		/// </summary>
		public List<LED> Leds { get; private set; }

		public int LEDCount { get => Leds.Count; }
		
		//public Channel() : this(0, 0) { }
		
		public Channel(int ledCount, int gpioPin) : this(ledCount, gpioPin, 255, false, StripType.Unknown)	{ }

		public Channel(int ledCount, int gpioPin, byte brightness, bool invert, StripType stripType)
		{
			GPIOPin = gpioPin;
			Invert = invert;
			Brightness = brightness;
			StripType = stripType;

			Leds = new List<LED>();
			for(int i= 0; i< ledCount; i++)
			{
				Leds.Add(new LED(i));
			}

			//LEDs = new ReadOnlyCollection<LED>(ledList);
		}

	}
}
