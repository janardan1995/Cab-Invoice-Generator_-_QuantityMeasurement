// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetToYardUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurement_TemperatureCalculation
{
    /// <summary>
    /// CelsiusToFahrenheith class
    /// </summary>
    public class CelsiusToFahrenheith
    {
        /// <summary>
        /// The celsius
        /// </summary>
        public double celsius;

        /// <summary>
        /// The fahrenheith
        /// </summary>
        public double fahrenheith;

        /// <summary>
        /// Initializes a new instance of the <see cref="CelsiusToFahrenheith"/> class.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        /// <param name="fahrenheith">The fahrenheith.</param>
        public CelsiusToFahrenheith(Celsius celsius, Fahrenheith fahrenheith)
        {
            this.celsius = celsius.celsius;
            this.fahrenheith = fahrenheith.fahrenheith;
        }

        /// <summary>
        /// Converteds the farhenheith tocelsius value.
        /// </summary>
        /// <param name="fahrenheith">The fahrenheith.</param>
        /// <returns></returns>
        public bool ConvertedFarhenheithTocelsiusValue(Fahrenheith fahrenheith)
        {

            if (this.celsius == 0 && this.fahrenheith == 0)
                return false;
            if (this.celsius.Equals((fahrenheith.fahrenheith - 32) / 1.8000))
                return true;
            return false;
        }

        /// <summary>
        /// Converteds the celsius to farhenheith value.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        /// <returns></returns>
        public bool ConvertedCelsiusToFarhenheithValue(Celsius celsius)
        {
            if (this.fahrenheith.Equals(celsius.celsius * 9 / 5 + 32))
                return true;
            return false;
        }
    }
}
