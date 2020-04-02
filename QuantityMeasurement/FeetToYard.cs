
namespace QuantityMeasurement
{
    /// <summary>
    /// Convert feet to yard and vice versa.
    /// </summary>
    public class FeetToYard
    {
        /// <summary>
        /// The feet
        /// </summary>
        public double feet;

        /// <summary>
        /// The yard
        /// </summary>
        public double yard;

        /// <summary>
        /// Initializes a new instance of the <see cref="FeetToYard"/> class.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <param name="yard">The yard.</param>
        public FeetToYard(Feet feet, Yard yard)
        {
            this.feet = feet.feet;
            this.yard = yard.yard;
        }

        /// <summary>
        /// Converteds the feet to yard value.
        /// </summary>
        /// <param name="yard">The yard.</param>
        /// <returns>boolean</returns>
        public bool ConvertedFeetToYardValue(Yard yard)
        {
            if (this.feet == 0 && (this.feet.Equals(yard.yard)))
                return true;
            if ((this.feet.Equals(3 * yard.yard)))
                return true;
            return false;
        }

        /// <summary>
        /// Converteds the yard to feet value.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <returns>boolean</returns>
        public bool ConvertedYardToFeetValue(Feet feet)
        {
            if (this.feet == 0 && (this.yard.Equals(feet.feet)))
                return true;
            if ((this.yard.Equals(feet.feet/3)))
                return true;
            return false;
        }
    }
}
