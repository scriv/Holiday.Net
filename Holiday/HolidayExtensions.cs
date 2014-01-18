using System.Linq;
using System.Threading.Tasks;

namespace Holiday
{
    /// <summary>
    /// Holiday extension methods.
    /// </summary>
    public static class HolidayExtensions
    {
        /// <summary>
        /// Gets the number of lights in a Holiday device.
        /// </summary>
        public const int NumberOfLights = 50;

        /// <summary>
        /// Sets all of the lights of a Holiday device to one colour.
        /// </summary>
        /// <param name="client">The Holiday client.</param>
        /// <param name="colour">The single colour to be set for all lights.</param>
        public static Task SetLights(this IHolidayClient client, Colour colour)
        {
            return client.SetLights(Enumerable.Repeat(colour, NumberOfLights));
        }
    }
}