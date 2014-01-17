using System.Collections.Generic;
using System.Threading.Tasks;

namespace Holiday
{
    /// <summary>
    /// Provides interaction with a Moore's Cloud Holiday device.
    /// </summary>
    public interface IHolidayClient
    {
        /// <summary>
        /// Sets the individual lights of the holiday device.
        /// </summary>
        /// <param name="lights">A collection of 50 hex colour values.</param>
        Task SetLights(IEnumerable<Colour> lights);
    }
}
