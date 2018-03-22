using rpi_ws281x;
using System;
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
			//Brightness and the invertable flag are set 255 and false in the constructor.
			//Use another constructor to set those values explicit.
			settings.Channels[0] = new Channel(16, 18);
			
			using (var rpi = new WS281x(settings))
			{
				while (!exitApplication)
				{
					ColorWipe(Color.Red, rpi);
					ColorWipe(Color.Green, rpi);
					ColorWipe(Color.Blue, rpi);
				}
			}
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
    }
}
