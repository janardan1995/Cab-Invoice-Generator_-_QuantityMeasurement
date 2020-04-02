// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetToInches.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurement
{
    /// <summary>
    /// FeetToInches Class
    /// </summary>
    public class FeetToInches
    {
        /// <summary>
        /// The feet
        /// </summary>
        public double feet;

        /// <summary>
        /// The inch
        /// </summary>
        public double inch;

        /// <summary>
        /// Initializes a new instance of the <see cref="FeetToInches"/> class.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <param name="inch">The inch.</param>
        public FeetToInches(Feet feet, Inch inch)
        {
            this.feet = feet.feet;
            this.inch = inch.inch;
        }

        /// <summary>
        /// Converteds the feet to inch value.
        /// </summary>
        /// <param name="inch">The inch.</param>
        /// <returns></returns>
        public bool ConvertedFeetToInchValue(Inch inch)
        {
            if (this.feet == 0 && (this.feet.Equals(inch.inch)))
                return true;
            if ((this.feet.Equals(inch.inch / 12)))
                return true;
            return false;
        }

        /// <summary>
        /// Converteds the inch to feet value.
        /// </summary>
        /// <param name="feet">The feet.</param>
        /// <returns></returns>
        public bool ConvertedInchToFeetValue(Feet feet)
        {
            if (this.feet == 0 && (this.inch.Equals(feet.feet)))
                return true;
            if ((this.inch.Equals(12 * feet.feet)))
                return true;
            return false;
        }
    }
}
