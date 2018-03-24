# rpi-ws281x-csharp
This is a C# wrapper for the great C assembly by Jeremy Garff to control WS281X LEDs by a Raspberry PI ([https://github.com/jgarff/rpi_ws281x](https://github.com/jgarff/rpi_ws281x)).
It uses the P/Invoke calls to access the native assembly.

## Usage
It is very easy to use the wrapper in your own C# / .NET project.
Just see the example below:

```csharp
//The default settings uses a frequency of 800000 Hz and the DMA channel 10.
var settings = Settings.CreateDefaultSettings();

//Use 16 LEDs and GPIO Pin 18.
//Set brightness to maximum (255)
//Use Unknown as strip type. Then the type will be set in the native assembly.
settings.Channels[0] = new Channel(16, 18, 255, false, StripType.WS2812_STRIP);

using (var rpi = new WS281x(settings))
{
  //Set the color of the first LED of channel 0 to blue
  rpi.SetLEDColor(0, 0, Color.Blue);
  //Set the color of the second LED of channel 0 to red
  rpi.SetLEDColor(0, 1, Color.Red);

  rpi.Render();
}
```
Please have a look at the [example program](src/TestApp/Program.cs) and get familiar with the usage.

## Installation
In order to get the wrapper working, you need build the shared C library first.
The required source code is included via a git submodule and is located under lib/rpi-ws281x.
This is a link to the original project.
Switch to the directory and execute following commands:
```
scons
gcc -shared -o ws2811.so *.o
```

The P/Invoke functinality has a [special search pattern](http://www.mono-project.com/docs/advanced/pinvoke/#library-handling) to find the required assembly.
For my tests I copied the ws2811.so assembly to /usr/lib (as mentioned in the link above).

## Test status
The wrapper was tested with following setup:

|Raspberry model | Controller | GPIO Pin | DMA channel | Result |
|----------------|------------|----------|-------------|--------|
|Model B Rev 2   | WS2812B    | 18       | 5, 10       | Success|

Please feel free to add some more test cases.
