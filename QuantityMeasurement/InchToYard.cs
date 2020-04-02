// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InchToYard.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurement
{
    /// <summary>
    /// yard into inches
    /// </summary>
    public class InchToYard
    {
        /// <summary>
        /// The inch
        /// </summary>
        public double inch;

        /// <summary>
        /// The yard
        /// </summary>
        public double yard;

        /// <summary>
        /// Initializes a new instance of the <see cref="InchToYard"/> class.
        /// </summary>
        /// <param name="inch">The inch.</param>
        /// <param name="yard">The yard.</param>
        public InchToYard(Inch inch, Yard yard)
        {
            this.inch = inch.inch;
            this.yard = yard.yard;
        }

        /// <summary>
        /// Converteds the yard to inch value.
        /// </summary>
        /// <param name="yard">The yard.</param>
        /// <returns>bool</returns>
        public bool ConvertedYardToInchValue(Yard yard)
        {
            if (this.inch == 0 && (this.inch.Equals(yard.yard)))
                return true;
            if ((this.inch.Equals(36 * yard.yard)))
                return true;
            return false;
        }
    }
}
