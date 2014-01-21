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
            IHolidayClient holiday = new RestHolidayClient(new Uri("http://localhost:2512/"));

            var steps = GetGradient(Colour.Black, Colour.Red, 100);

            steps = steps.Concat(steps.Reverse());

            while (true)
            {
                foreach (var stop in steps)
                {
                    holiday.SetLights(stop).Wait();
                    Thread.Sleep(10);
                }
            }
        }

        public static IEnumerable<Colour> GetGradient(Colour start, Colour end, int steps)
        {
            var colourList = new List<Colour>();
            var firstStep = 0;
            var lastStep = steps - 1;

            if (steps <= 0 || firstStep < 0 || lastStep > steps - 1)
            {
                return colourList;
            }

            double rStep = (end.R - start.R) / steps;
            double gStep = (end.G - start.G) / steps;
            double bStep = (end.B - start.B) / steps;

            for (int i = firstStep; i < lastStep; i++)
            {
                var r = start.R + (int)(rStep * i);
                var g = start.G + (int)(gStep * i);
                var b = start.B + (int)(bStep * i);

                colourList.Add(new Colour((byte)r, (byte)g, (byte)b));
            }

            return colourList;
        }
    }
}