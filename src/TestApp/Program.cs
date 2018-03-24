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
			var abort = new AbortRequest();

			Console.CancelKeyPress += (s, e) =>
			{
				e.Cancel = true;
				abort.IsAbortRequested = true;
			};
		
			var input = 0;
			do
			{
				Console.Clear();
				Console.WriteLine("What do you want to test:");
				Console.WriteLine("Press CTRL + C to abort to current test.");
				Console.WriteLine("0 - Exit");
				Console.WriteLine("1 - Color wipe animation");
				Console.WriteLine("2 - Rainbow color animation");

				Console.Write("What is your choice: ");
				input = Int32.Parse(Console.ReadLine());

				var animation = GetAnimation(input);
				if(animation != null)
				{
					abort.IsAbortRequested = false;
					animation.Execute(abort);
				}
				
			} while (input != 0);
		}

		private static IAnimation GetAnimation(int code)
		{
			IAnimation result = null;

			switch(code)
			{
				case 1:
					result = new ColorWipe();
					break;

				case 2:
					result = new RainbowColorAnimation();
					break;
			}

			return result;
		}
    }
}
