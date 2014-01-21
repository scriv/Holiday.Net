using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            IHolidayClient client = new RestHolidayClient(new Uri("http://localhost:2512/"));

            client.SetLights(Colour.White).Wait();
        }
    }
}