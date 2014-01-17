Holiday.NET
===========

A portable .NET Moore's Cloud Holiday client library usable by .NET, Silverlight, Windows Store apps, and Windows Phone 8.

Can be installed from Nuget: https://www.nuget.org/packages/Holiday.Net/

`PM> Install-Package Holiday.Net`

Using this class library you can interface with your Holiday device:

``` c#
IHolidayClient holiday = new RestHolidayClient(new Uri("http://192.168.2.120"));

await holiday.SetLights(Enumerable.Repeat(Colour.White, 50));
```
