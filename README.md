Holiday.Net
===========

A portable .NET [Moore's Cloud Holiday](http://www.moorescloud.com/) client library usable by .NET 4.5, Silverlight, Windows Store apps, and Windows Phone 8.

Can be installed from [Nuget](https://www.nuget.org/packages/Holiday.Net/): `PM> Install-Package Holiday.Net`

Using this class library you can interface with your Holiday device:

``` c#
IHolidayClient holiday = new RestHolidayClient(new Uri("http://192.168.2.120"));

// Initiates a colour gradient animation over a specified duration
holiday.Gradient(Colour.Black, Colour.Red, TimeSpan.FromSeconds(0.5)).Wait();

// Get the colour value of a specific lamp
var lampColour = holiday.GetLampColour(0).Result;

// Set the colour of a specific lamp
holiday.SetLampColour(0, Colour.HotPink).Wait();

// Set all lights to the same colour
holiday.SetLights(Enumerable.Repeat(Colour.Gold, 50)).Wait();
```
