using System;

namespace Holiday
{
    /// <summary>
    /// Translates colors to and from Holiday Colour structures. This class cannot be inherited.
    /// </summary>
    public static class ColourTranslator
    {
        /// <summary>
        /// Translates an HTML colour representation to an RGB colour.
        /// </summary>
        /// <param name="htmlColour">The string representation of the HTML color to translate.</param>
        /// <returns>The <see cref="Colour"/> structure that represents the translated HTML color or Empty if <paramref name="htmlColour"/> is <c>null</c>.</returns>
        public static Colour FromHtml(string htmlColour)
        {
            if (string.IsNullOrWhiteSpace(htmlColour))
            {
                return Colour.Empty;
            }

            if (htmlColour[0] != '#' || (htmlColour.Length != 7 && htmlColour.Length != 4))
            {
                throw new FormatException("The HTML colour must be in the format #RRGGBB or #RGB.");
            }

            int partLength = htmlColour.Length == 7 ? 2 : 1;

            string red = htmlColour.Substring(1, partLength);
            string green = htmlColour.Substring(1 + partLength, partLength);
            string blue = htmlColour.Substring(2 + partLength, partLength);

            if (partLength == 1)
            {
                red += red;
                green += green;
                blue += blue;
            }

            return new Colour(Convert.ToByte(red, 16), Convert.ToByte(green, 16), Convert.ToByte(blue, 16));
        }

        /// <summary>
        /// Translates a Holiday colour to an HTML colour.
        /// </summary>
        /// <param name="colour">The Holiday colour to translate.</param>
        /// <returns>The HTML colour representing the Holiday colour.</returns>
        public static string ToHtml(this Colour colour)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", colour.R, colour.G, colour.B);
        }
    }
}