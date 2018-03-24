using rpi_ws281x;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	class ColorWipe : IAnimation
	{
		public void Execute(AbortRequest request)
		{
			Console.Clear();
			Console.Write("How many LEDs to you want to use: ");

			var ledCount = Int32.Parse(Console.ReadLine());

			//The default settings uses a frequency of 800000 Hz and the DMA channel 10.
			var settings = Settings.CreateDefaultSettings();

			//Set brightness to maximum (255)
			//Use Unknown as strip type. Then the type will be set in the native assembly.
			settings.Channels[0] = new Channel(ledCount, 18, 255, false, StripType.WS2812_STRIP);

			using (var controller = new WS281x(settings))
			{
				while(!request.IsAbortRequested)
				{
					Wipe(controller, Color.Red);
					Wipe(controller, Color.Green);
					Wipe(controller, Color.Blue);
				}
			}
		}

		private static void Wipe(WS281x controller, Color color)
		{
			for (int i = 0; i <= controller.Settings.Channels[0].LEDs.Count - 1; i++)
			{
				controller.SetLEDColor(0, i, color);
				controller.Render();
				System.Threading.Thread.Sleep(1000 / 15);
			}
		}
	}
}
