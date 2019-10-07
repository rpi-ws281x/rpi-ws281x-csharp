using System.Drawing;

namespace WS281x
{
	/// <summary>
	/// Represents a LED which can be controlled by the WS281x controller
	/// </summary>
	public class LED
	{
		/// <summary>
		/// LED which can be controlled by the WS281x controller
		/// </summary>
		/// <param name="id">ID / index of the LED</param>
		public LED(int id)
		{
			ID = id;
			Color = Color.Empty;
		}

		/// <summary>
		/// Returns the ID / index of the LED
		/// </summary>
		public int ID { get; private set; }

		/// <summary>
		/// Gets or sets the color for the LED
		/// </summary>
		public Color Color { get; set; }

		/// <summary>
		/// Returns the RGB value of the color
		/// </summary>
		public int RGBValue { get => Color.ToArgb(); }

	}
}
