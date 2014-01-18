
namespace Holiday
{
    /// <summary>
    /// Represents an RGB (Red, Green and Blue) colour.
    /// </summary>
    public partial struct Colour
    {
        #region Named colours

        /// <summary>
        /// Gets the colour white.
        /// </summary>
        public static Colour White { get { return new Colour(255, 255, 255); } }

        /// <summary>
        /// Gets the colour black.
        /// </summary>
        public static Colour Black { get { return new Colour(0, 0, 0); } }

        /// <summary>
        /// Gets the colour red.
        /// </summary>
        public static Colour Red { get { return new Colour(255, 0, 0); } }

        /// <summary>
        /// Gets the colour yellow.
        /// </summary>
        public static Colour Yellow { get { return new Colour(255, 255, 0); } }

        /// <summary>
        /// Gets the colour green.
        /// </summary>
        public static Colour Green { get { return new Colour(0, 128, 0); } }

        /// <summary>
        /// Gets the colour blue.
        /// </summary>
        public static Colour Blue { get { return new Colour(0, 0, 255); } }

        /// <summary>
        /// Gets the colour teal.
        /// </summary>
        public static Colour Teal { get { return new Colour(0, 128, 128); } }

        /// <summary>
        /// Gets the colour alice blue.
        /// </summary>
        public static Colour AliceBlue { get { return new Colour(240, 248, 255); } }

        /// <summary>
        /// Gets the colour antique white.
        /// </summary>
        public static Colour AntiqueWhite { get { return new Colour(250, 235, 215); } }

        /// <summary>
        /// Gets the colour aqua.
        /// </summary>
        public static Colour Aqua { get { return new Colour(0, 255, 255); } }

        /// <summary>
        /// Gets the colour aquamarine.
        /// </summary>
        public static Colour Aquamarine { get { return new Colour(127, 255, 212); } }

        /// <summary>
        /// Gets the colour azure.
        /// </summary>
        public static Colour Azure { get { return new Colour(240, 255, 255); } }

        /// <summary>
        /// Gets the colour beige.
        /// </summary>
        public static Colour Beige { get { return new Colour(245, 245, 220); } }

        /// <summary>
        /// Gets the colour bisque.
        /// </summary>
        public static Colour Bisque { get { return new Colour(255, 228, 196); } }

        /// <summary>
        /// Gets the colour blanched almond.
        /// </summary>
        public static Colour BlanchedAlmond { get { return new Colour(255, 235, 205); } }

        /// <summary>
        /// Gets the colour blue violet.
        /// </summary>
        public static Colour BlueViolet { get { return new Colour(138, 43, 226); } }

        /// <summary>
        /// Gets the colour brown.
        /// </summary>
        public static Colour Brown { get { return new Colour(165, 42, 42); } }

        /// <summary>
        /// Gets the colour burlywood.
        /// </summary>
        public static Colour Burlywood { get { return new Colour(222, 184, 135); } }

        /// <summary>
        /// Gets the colour cadet blue.
        /// </summary>
        public static Colour CadetBlue { get { return new Colour(95, 158, 160); } }

        /// <summary>
        /// Gets the colour chartreuse.
        /// </summary>
        public static Colour Chartreuse { get { return new Colour(127, 255, 0); } }

        /// <summary>
        /// Gets the colour chocolate.
        /// </summary>
        public static Colour Chocolate { get { return new Colour(210, 105, 30); } }

        /// <summary>
        /// Gets the colour Coral.
        /// </summary>
        public static Colour Coral { get { return new Colour(255, 127, 80); } }

        /// <summary>
        /// Gets the colour cornflower blue.
        /// </summary>
        public static Colour CornflowerBlue { get { return new Colour(100, 149, 237); } }

        /// <summary>
        /// Gets the colour cornsilk.
        /// </summary>
        public static Colour Cornsilk { get { return new Colour(255, 248, 220); } }

        /// <summary>
        /// Gets the colour crimson.
        /// </summary>
        public static Colour Crimson { get { return new Colour(220, 20, 60); } }

        /// <summary>
        /// Gets the colour cyan.
        /// </summary>
        public static Colour Cyan { get { return new Colour(0, 255, 255); } }

        /// <summary>
        /// Gets the colour dark blue.
        /// </summary>
        public static Colour DarkBlue { get { return new Colour(0, 0, 139); } }

        /// <summary>
        /// Gets the colour dark cyan.
        /// </summary>
        public static Colour DarkCyan { get { return new Colour(0, 139, 139); } }

        /// <summary>
        /// Gets the colour dark goldenrod.
        /// </summary>
        public static Colour DarkGoldenrod { get { return new Colour(184, 134, 11); } }

        /// <summary>
        /// Gets the colour dark grey.
        /// </summary>
        public static Colour DarkGrey { get { return new Colour(169, 169, 169); } }

        /// <summary>
        /// Gets the colour dark green.
        /// </summary>
        public static Colour DarkGreen { get { return new Colour(0, 100, 0); } }

        /// <summary>
        /// Gets the colour dark khaki.
        /// </summary>
        public static Colour DarkKhaki { get { return new Colour(189, 183, 107); } }

        /// <summary>
        /// Gets the colour dark magenta.
        /// </summary>
        public static Colour DarkMagenta { get { return new Colour(139, 0, 139); } }

        /// <summary>
        /// Gets the colour dark olive green.
        /// </summary>
        public static Colour DarkOliveGreen { get { return new Colour(85, 107, 47); } }

        /// <summary>
        /// Gets the colour dark orange.
        /// </summary>
        public static Colour DarkOrange { get { return new Colour(255, 140, 0); } }

        /// <summary>
        /// Gets the colour dark orchid.
        /// </summary>
        public static Colour DarkOrchid { get { return new Colour(153, 50, 204); } }

        /// <summary>
        /// Gets the colour dark red.
        /// </summary>
        public static Colour DarkRed { get { return new Colour(139, 0, 0); } }

        /// <summary>
        /// Gets the colour dark salmon.
        /// </summary>
        public static Colour DarkSalmon { get { return new Colour(233, 150, 122); } }

        /// <summary>
        /// Gets the colour dark sea green.
        /// </summary>
        public static Colour DarkSeaGreen { get { return new Colour(143, 188, 143); } }

        /// <summary>
        /// Gets the colour dark slate blue.
        /// </summary>
        public static Colour DarkSlateBlue { get { return new Colour(72, 61, 139); } }

        /// <summary>
        /// Gets the colour dark slate grey.
        /// </summary>
        public static Colour DarkSlateGrey { get { return new Colour(47, 79, 79); } }

        /// <summary>
        /// Gets the colour dark turquoise.
        /// </summary>
        public static Colour DarkTurquoise { get { return new Colour(0, 206, 209); } }

        /// <summary>
        /// Gets the colour dark violet.
        /// </summary>
        public static Colour DarkViolet { get { return new Colour(148, 0, 211); } }

        /// <summary>
        /// Gets the colour deep pink.
        /// </summary>
        public static Colour DeepPink { get { return new Colour(255, 20, 147); } }

        /// <summary>
        /// Gets the colour deep sky blue.
        /// </summary>
        public static Colour DeepSkyBlue { get { return new Colour(0, 191, 255); } }

        /// <summary>
        /// Gets the colour dim grey.
        /// </summary>
        public static Colour DimGrey { get { return new Colour(105, 105, 105); } }

        /// <summary>
        /// Gets the colour dodger blue.
        /// </summary>
        public static Colour DodgerBlue { get { return new Colour(30, 144, 255); } }

        /// <summary>
        /// Gets the colour firebrick.
        /// </summary>
        public static Colour Firebrick { get { return new Colour(178, 34, 34); } }

        /// <summary>
        /// Gets the colour floral white.
        /// </summary>
        public static Colour FloralWhite { get { return new Colour(255, 250, 240); } }

        /// <summary>
        /// Gets the colour forest green.
        /// </summary>
        public static Colour ForestGreen { get { return new Colour(34, 139, 34); } }

        /// <summary>
        /// Gets the colour fuchsia.
        /// </summary>
        public static Colour Fuchsia { get { return new Colour(255, 0, 255); } }

        /// <summary>
        /// Gets the colour gainsboro.
        /// </summary>
        public static Colour Gainsboro { get { return new Colour(220, 220, 220); } }

        /// <summary>
        /// Gets the colour ghost white.
        /// </summary>
        public static Colour GhostWhite { get { return new Colour(248, 248, 255); } }

        /// <summary>
        /// Gets the colour gold.
        /// </summary>
        public static Colour Gold { get { return new Colour(255, 215, 0); } }

        /// <summary>
        /// Gets the colour grey.
        /// </summary>
        public static Colour Grey { get { return new Colour(128, 128, 128); } }

        /// <summary>
        /// Gets the colour green-yellow.
        /// </summary>
        public static Colour GreenYellow { get { return new Colour(173, 255, 47); } }

        /// <summary>
        /// Gets the colour honeydew.
        /// </summary>
        public static Colour Honeydew { get { return new Colour(240, 255, 240); } }

        /// <summary>
        /// Gets the colour hot pink.
        /// </summary>
        public static Colour HotPink { get { return new Colour(255, 105, 180); } }

        /// <summary>
        /// Gets the colour Indian red.
        /// </summary>
        public static Colour IndianRed { get { return new Colour(205, 92, 92); } }

        /// <summary>
        /// Gets the colour indigo.
        /// </summary>
        public static Colour Indigo { get { return new Colour(75, 0, 130); } }

        /// <summary>
        /// Gets the colour ivory.
        /// </summary>
        public static Colour Ivory { get { return new Colour(255, 255, 240); } }

        /// <summary>
        /// Gets the colour khaki.
        /// </summary>
        public static Colour Khaki { get { return new Colour(240, 230, 140); } }

        /// <summary>
        /// Gets the colour lavender.
        /// </summary>
        public static Colour Lavender { get { return new Colour(230, 230, 250); } }

        /// <summary>
        /// Gets the colour lavender blush.
        /// </summary>
        public static Colour LavenderBlush { get { return new Colour(255, 240, 245); } }

        /// <summary>
        /// Gets the colour lawn-green.
        /// </summary>
        public static Colour LawnGreen { get { return new Colour(124, 252, 0); } }

        /// <summary>
        /// Gets the colour lemon-chiffon.
        /// </summary>
        public static Colour LemonChiffon { get { return new Colour(255, 250, 205); } }

        /// <summary>
        /// Gets the colour light blue.
        /// </summary>
        public static Colour LightBlue { get { return new Colour(173, 216, 230); } }

        /// <summary>
        /// Gets the colour light coral.
        /// </summary>
        public static Colour LightCoral { get { return new Colour(240, 128, 128); } }

        /// <summary>
        /// Gets the colour light cyan.
        /// </summary>
        public static Colour LightCyan { get { return new Colour(224, 255, 255); } }

        /// <summary>
        /// Gets the colour light goldenrod-yellow.
        /// </summary>
        public static Colour LightGoldenrodYellow { get { return new Colour(250, 250, 210); } }

        /// <summary>
        /// Gets the colour light green.
        /// </summary>
        public static Colour LightGreen { get { return new Colour(144, 238, 144); } }

        /// <summary>
        /// Gets the colour light grey.
        /// </summary>
        public static Colour LightGrey { get { return new Colour(211, 211, 211); } }

        /// <summary>
        /// Gets the colour light pink.
        /// </summary>
        public static Colour LightPink { get { return new Colour(255, 182, 193); } }

        /// <summary>
        /// Gets the colour light salmon.
        /// </summary>
        public static Colour LightSalmon { get { return new Colour(255, 160, 122); } }

        /// <summary>
        /// Gets the colour light sea-green.
        /// </summary>
        public static Colour LightSeaGreen { get { return new Colour(32, 178, 170); } }

        /// <summary>
        /// Gets the colour light sky-blue.
        /// </summary>
        public static Colour LightSkyBlue { get { return new Colour(135, 206, 250); } }

        /// <summary>
        /// Gets the colour light slate-grey.
        /// </summary>
        public static Colour LightSlateGrey { get { return new Colour(119, 136, 153); } }

        /// <summary>
        /// Gets the colour light steel-blue.
        /// </summary>
        public static Colour LightSteelBlue { get { return new Colour(176, 196, 222); } }

        /// <summary>
        /// Gets the colour light yellow.
        /// </summary>
        public static Colour LightYellow { get { return new Colour(255, 255, 224); } }

        /// <summary>
        /// Gets the colour lime.
        /// </summary>
        public static Colour Lime { get { return new Colour(0, 255, 0); } }

        /// <summary>
        /// Gets the colour lime-green.
        /// </summary>
        public static Colour LimeGreen { get { return new Colour(50, 205, 50); } }

        /// <summary>
        /// Gets the colour linen.
        /// </summary>
        public static Colour Linen { get { return new Colour(250, 240, 230); } }

        /// <summary>
        /// Gets the colour magenta.
        /// </summary>
        public static Colour Magenta { get { return new Colour(255, 0, 255); } }

        /// <summary>
        /// Gets the colour maroon.
        /// </summary>
        public static Colour Maroon { get { return new Colour(128, 0, 0); } }

        /// <summary>
        /// Gets the colour medium aquamarine.
        /// </summary>
        public static Colour MediumAquamarine { get { return new Colour(102, 205, 170); } }

        /// <summary>
        /// Gets the colour medium-blue.
        /// </summary>
        public static Colour MediumBlue { get { return new Colour(0, 0, 205); } }

        /// <summary>
        /// Gets the colour medium-orchid.
        /// </summary>
        public static Colour MediumOrchid { get { return new Colour(186, 85, 211); } }

        /// <summary>
        /// Gets the colour medium-purple.
        /// </summary>
        public static Colour MediumPurple { get { return new Colour(147, 112, 219); } }

        /// <summary>
        /// Gets the colour medium sea-green.
        /// </summary>
        public static Colour MediumSeaGreen { get { return new Colour(60, 179, 113); } }

        /// <summary>
        /// Gets the colour medium slate-blue.
        /// </summary>
        public static Colour MediumSlateBlue { get { return new Colour(123, 104, 238); } }

        /// <summary>
        /// Gets the colour medium spring-green.
        /// </summary>
        public static Colour MediumSpringGreen { get { return new Colour(0, 250, 154); } }

        /// <summary>
        /// Gets the colour medium-turquoise.
        /// </summary>
        public static Colour MediumTurquoise { get { return new Colour(72, 209, 204); } }

        /// <summary>
        /// Gets the colour medium violet-red.
        /// </summary>
        public static Colour MediumVioletRed { get { return new Colour(199, 21, 133); } }

        /// <summary>
        /// Gets the colour midnight blue.
        /// </summary>
        public static Colour MidnightBlue { get { return new Colour(25, 25, 112); } }

        /// <summary>
        /// Gets the colour mint cream.
        /// </summary>
        public static Colour MintCream { get { return new Colour(245, 255, 250); } }

        /// <summary>
        /// Gets the colour misty rose.
        /// </summary>
        public static Colour MistyRose { get { return new Colour(255, 228, 225); } }

        /// <summary>
        /// Gets the colour moccasin.
        /// </summary>
        public static Colour Moccasin { get { return new Colour(255, 228, 181); } }

        /// <summary>
        /// Gets the colour navajo white.
        /// </summary>
        public static Colour NavajoWhite { get { return new Colour(255, 222, 173); } }

        /// <summary>
        /// Gets the colour navy.
        /// </summary>
        public static Colour Navy { get { return new Colour(0, 0, 128); } }

        /// <summary>
        /// Gets the colour old lace.
        /// </summary>
        public static Colour OldLace { get { return new Colour(253, 245, 230); } }

        /// <summary>
        /// Gets the colour olive.
        /// </summary>
        public static Colour Olive { get { return new Colour(128, 128, 0); } }

        /// <summary>
        /// Gets the colour olive drab.
        /// </summary>
        public static Colour OliveDrab { get { return new Colour(107, 142, 35); } }

        /// <summary>
        /// Gets the colour orange.
        /// </summary>
        public static Colour Orange { get { return new Colour(255, 165, 0); } }

        /// <summary>
        /// Gets the colour orange-red.
        /// </summary>
        public static Colour OrangeRed { get { return new Colour(255, 69, 0); } }

        /// <summary>
        /// Gets the colour orchid.
        /// </summary>
        public static Colour Orchid { get { return new Colour(218, 112, 214); } }

        /// <summary>
        /// Gets the colour pale goldenrod.
        /// </summary>
        public static Colour PaleGoldenrod { get { return new Colour(238, 232, 170); } }

        /// <summary>
        /// Gets the colour pale green.
        /// </summary>
        public static Colour PaleGreen { get { return new Colour(152, 251, 152); } }

        /// <summary>
        /// Gets the colour pale turquoise.
        /// </summary>
        public static Colour PaleTurquoise { get { return new Colour(175, 238, 238); } }

        /// <summary>
        /// Gets the colour pale violet-red.
        /// </summary>
        public static Colour PaleVioletRed { get { return new Colour(219, 112, 147); } }

        /// <summary>
        /// Gets the colour papayaWhip.
        /// </summary>
        public static Colour PapayaWhip { get { return new Colour(255, 239, 213); } }

        /// <summary>
        /// Gets the colour peach puff.
        /// </summary>
        public static Colour PeachPuff { get { return new Colour(255, 218, 185); } }

        /// <summary>
        /// Gets the colour peru.
        /// </summary>
        public static Colour Peru { get { return new Colour(205, 133, 63); } }

        /// <summary>
        /// Gets the colour pink.
        /// </summary>
        public static Colour Pink { get { return new Colour(255, 192, 203); } }

        /// <summary>
        /// Gets the colour plum.
        /// </summary>
        public static Colour Plum { get { return new Colour(221, 160, 221); } }

        /// <summary>
        /// Gets the colour powder-blue.
        /// </summary>
        public static Colour PowderBlue { get { return new Colour(176, 224, 230); } }

        /// <summary>
        /// Gets the colour purple.
        /// </summary>
        public static Colour Purple { get { return new Colour(128, 0, 128); } }

        /// <summary>
        /// Gets the colour rosy brown.
        /// </summary>
        public static Colour RosyBrown { get { return new Colour(188, 143, 143); } }

        /// <summary>
        /// Gets the colour royal blue.
        /// </summary>
        public static Colour RoyalBlue { get { return new Colour(65, 105, 225); } }

        /// <summary>
        /// Gets the colour saddle brown.
        /// </summary>
        public static Colour SaddleBrown { get { return new Colour(139, 69, 19); } }

        /// <summary>
        /// Gets the colour salmon.
        /// </summary>
        public static Colour Salmon { get { return new Colour(250, 128, 114); } }

        /// <summary>
        /// Gets the colour sandy brown.
        /// </summary>
        public static Colour SandyBrown { get { return new Colour(244, 164, 96); } }

        /// <summary>
        /// Gets the colour sea green.
        /// </summary>
        public static Colour SeaGreen { get { return new Colour(46, 139, 87); } }

        /// <summary>
        /// Gets the colour sea shell.
        /// </summary>
        public static Colour SeaShell { get { return new Colour(255, 245, 238); } }

        /// <summary>
        /// Gets the colour sienna.
        /// </summary>
        public static Colour Sienna { get { return new Colour(160, 82, 45); } }

        /// <summary>
        /// Gets the colour silver.
        /// </summary>
        public static Colour Silver { get { return new Colour(192, 192, 192); } }

        /// <summary>
        /// Gets the colour sky blue.
        /// </summary>
        public static Colour SkyBlue { get { return new Colour(135, 206, 235); } }

        /// <summary>
        /// Gets the colour slate blue.
        /// </summary>
        public static Colour SlateBlue { get { return new Colour(106, 90, 205); } }

        /// <summary>
        /// Gets the colour slate grey.
        /// </summary>
        public static Colour SlateGrey { get { return new Colour(112, 128, 144); } }

        /// <summary>
        /// Gets the colour snow.
        /// </summary>
        public static Colour Snow { get { return new Colour(255, 250, 250); } }

        /// <summary>
        /// Gets the colour spring green.
        /// </summary>
        public static Colour SpringGreen { get { return new Colour(0, 255, 127); } }

        /// <summary>
        /// Gets the colour steel blue.
        /// </summary>
        public static Colour SteelBlue { get { return new Colour(70, 130, 180); } }

        /// <summary>
        /// Gets the colour tan.
        /// </summary>
        public static Colour Tan { get { return new Colour(210, 180, 140); } }

        /// <summary>
        /// Gets the colour thistle.
        /// </summary>
        public static Colour Thistle { get { return new Colour(216, 191, 216); } }

        /// <summary>
        /// Gets the colour tomato.
        /// </summary>
        public static Colour Tomato { get { return new Colour(255, 99, 71); } }

        /// <summary>
        /// Gets the colour turquoise.
        /// </summary>
        public static Colour Turquoise { get { return new Colour(64, 224, 208); } }

        /// <summary>
        /// Gets the colour violet.
        /// </summary>
        public static Colour Violet { get { return new Colour(238, 130, 238); } }

        /// <summary>
        /// Gets the colour wheat.
        /// </summary>
        public static Colour Wheat { get { return new Colour(245, 222, 179); } }

        /// <summary>
        /// Gets the colour yellow-green.
        /// </summary>
        public static Colour YellowGreen { get { return new Colour(154, 205, 50); } }

        #endregion
    }
}