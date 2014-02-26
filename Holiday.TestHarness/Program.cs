using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Holiday.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            //IHolidayClient holiday = new RestHolidayClient(new Uri("http://localhost:2512/"));
            IHolidayClient holiday = new RestHolidayClient(new Uri("http://192.168.2.8/"));

            //holiday.SetLampColour(0, Colour.DodgerBlue).Wait();
            //Console.WriteLine(holiday.GetLampColour(0).Result);

            var begin = Colour.Empty;
            var end = Colour.Red;
            var duration = TimeSpan.FromSeconds(0.5);

            while (true)
            {
                holiday.Gradient(begin, end, duration).Wait();
                Thread.Sleep(duration);

                var newBegin = end;
                var newEnd = begin;

                begin = newBegin;
                end = newEnd;
            }
        }
    }
}