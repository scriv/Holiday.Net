using System;
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

        /// <summary>
        /// Performs a gradient – an even transition – across all of the globes on a string together, moving in concert from one colour to another colour.
        /// </summary>
        /// <param name="begin">The colour to start with</param>
        /// <param name="end">The colour to end with</param>
        /// <param name="duration">The duration of the transition.</param>
        Task Gradient(Colour begin, Colour end, TimeSpan duration);

        /// <summary>
        /// Gets the <see cref="Colour"/> of an individual lamp on the holiday device.
        /// </summary>
        /// <param name="lampPosition">The lamp position (0 - 49).</param>
        /// <returns>The <see cref="Colour"/> of the lamp.</returns>
        Task<Colour> GetLampColour(int lampPosition);

        /// <summary>
        /// Sets the <see cref="Colour"/> of an individual lamp on the holiday device.
        /// </summary>
        /// <param name="lampPosition">The lamp position (0 - 49).</param>
        /// <param name="colour">The <see cref="Colour"/> that the lamp should be set to.</param>
        Task SetLampColour(int lampPosition, Colour colour);
    }
}