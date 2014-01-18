
namespace Holiday
{
    /// <summary>
    /// Represents an RGB (Red, Green and Blue) colour.
    /// </summary>
    public partial struct Colour
    {
        /// <summary>
        /// Represents a null colour.
        /// </summary>
        public static readonly Colour Empty = new Colour();

        /// <summary>
        /// Initializes a new instance of the <see cref="Colour"/> struct.
        /// </summary>
        /// <param name="red">The red component.</param>
        /// <param name="green">The green component.</param>
        /// <param name="blue">The blue component.</param>
        public Colour(byte red, byte green, byte blue)
            : this()
        {
            this.R = red;
            this.G = green;
            this.B = blue;
        }

        /// <summary>
        /// Gets the red component of the colour.
        /// </summary>
        public byte R { get; private set; }

        /// <summary>
        /// Gets the green component of the colour.
        /// </summary>
        public byte G { get; private set; }

        /// <summary>
        /// Gets the blue component of the colour.
        /// </summary>
        public byte B { get; private set; }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return this.R.GetHashCode() ^ this.G.GetHashCode() ^ this.B.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return ColourTranslator.ToHtml(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" }, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Colour))
            {
                return false;
            }

            return this == (Colour)obj;
        }

        /// <summary>
        /// Tests whether two specified Colour structures are equivalent.
        /// </summary>
        /// <param name="left">The Colour that is to the left of the equality operator.</param>
        /// <param name="right">The Colour that is to the right of the equality operator.</param>
        /// <returns><c>true</c> if they are equal; otherwise <c>false</c>.</returns>
        public static bool operator ==(Colour left, Colour right)
        {
            if (left.R != right.R || (int)left.G != (int)right.G || (int)left.B != (int)right.B)
                return false;

            return true;
        }

        /// <summary>
        /// Tests whether two specified Colour structures are different.
        /// </summary>
        /// <param name="left">The Colour that is to the left of the inequality  operator.</param>
        /// <param name="right">The Colour that is to the right of the inequality  operator.</param>
        /// <returns><c>true</c> if they are different; otherwise <c>false</c>.</returns>
        public static bool operator !=(Colour left, Colour right)
        {
            return !(left == right);
        }
    }
}