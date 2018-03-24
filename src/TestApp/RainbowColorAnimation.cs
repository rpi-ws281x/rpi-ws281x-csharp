using rpi_ws281x;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	class RainbowColorAnimation : IAnimation
	{
		private static int colorOffset = 0;

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
				var colors = GetAnimationColors();
				while (!request.IsAbortRequested)
				{
				
					for (int i = 0; i <= controller.Settings.Channels[0].LEDCount - 1; i++)
					{
						var colorIndex = (i + colorOffset) % colors.Count;
						controller.SetLEDColor(0, i, colors[colorIndex]);
					}

					controller.Render();

					if (colorOffset == int.MaxValue)
					{
						colorOffset = 0;
					}
					colorOffset++;
					System.Threading.Thread.Sleep(50);
				}
			}
		}

		private static List<Color> GetAnimationColors()
		{
			var result = new List<Color>();

			result.Add(Color.FromArgb(0x201000));
			result.Add(Color.FromArgb(0x202000));
			result.Add(Color.Green);
			result.Add(Color.FromArgb(0x002020));
			result.Add(Color.Blue);
			result.Add(Color.FromArgb(0x100010));
			result.Add(Color.FromArgb(0x200010));

			return result;
		}
	}
}
