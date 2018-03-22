using rpi_ws281x;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TestApp
{
	class Program
    {
        static void Main(string[] args)
        {
			var exitApplication = false;
			Console.CancelKeyPress += (s, e) =>
			{
				e.Cancel = true;
				exitApplication = true;
			};
			
			//The default settings uses a frequency of 800000 Hz and the DMA channel 5.
			var settings = Settings.CreateDefaultSettings();

			//Use 16 LEDs and GPIO Pin 18.
			//Set brightness to maximum (255)
			//Use Unknown as strip type. Then the type will be set in the native assembly.
			settings.Channels[0] = new Channel(16, 18, 255, false, StripType.WS2812_STRIP);
			
			using (var rpi = new WS281x(settings))
			{
				while (!exitApplication)
				{
					//DoColorWipe(rpi);
					DoAnimation(rpi);
				}
			}
		}

		private static void DoColorWipe(WS281x rpi)
		{
			ColorWipe(Color.Red, rpi);
			ColorWipe(Color.Green, rpi);
			ColorWipe(Color.Blue, rpi);
		}

		private static void ColorWipe(Color color, WS281x rpi)
		{
			for(int i=0; i<= rpi.Settings.Channels[0].LEDs.Count -1; i++)
			{
				rpi.SetLEDColor(0, i, color);
				rpi.Render();
				System.Threading.Thread.Sleep(1000 / 15);
			}
		}

		private static int colorOffset = 0;
		private static void DoAnimation(WS281x rpi)
		{
			var colors = GetAnimationColors();
			
			for(int i=0; i<= rpi.Settings.Channels[0].LEDCount -1; i++)
			{
				var colorIndex = (i + colorOffset) % colors.Count;
				rpi.SetLEDColor(0, i, colors[colorIndex]);
			}

			rpi.Render();
			colorOffset++;
			System.Threading.Thread.Sleep(50);
		}

		private static List<Color> GetAnimationColors()
		{
			var result = new List<Color>();

			result.Add(Color.FromArgb(0x201000));
			result.Add(Color.FromArgb(0x202000));
			result.Add(Color.FromArgb(0x002000));
			result.Add(Color.FromArgb(0x002020));
			result.Add(Color.FromArgb(0x000020));
			result.Add(Color.FromArgb(0x100010));
			result.Add(Color.FromArgb(0x200010));

			return result;
		}
    }
}
