// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KilogramToGram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasure_Weight
{
    /// <summary>
    /// KilogramToGram class
    /// </summary>
    public class KilogramToGram
    {
        /// <summary>
        /// The kilogram
        /// </summary>
        public double kilogram;

        /// <summary>
        /// The gram
        /// </summary>
        public double gram;

        /// <summary>
        /// Initializes a new instance of the <see cref="KilogramToGram"/> class.
        /// </summary>
        /// <param name="kilogram">The kilogram.</param>
        /// <param name="gram">The gram.</param>
        public KilogramToGram(Kilogram kilogram, Gram gram)
        {
            this.kilogram = kilogram.kilogram;
            this.gram = gram.gram;
        }

        /// <summary>
        /// Converteds the gram to kilogram value.
        /// </summary>
        /// <param name="gram">The gram.</param>
        /// <returns></returns>
        public bool ConvertedGramToKilogramValue(Gram gram)
        {           
            if (this.kilogram == 0 && this.gram == 0)
                return false;
            if (this.kilogram.Equals(gram.gram/1000))
                return true;

            return false;
        }

        /// <summary>
        /// Converteds the kilogram to gram value.
        /// </summary>
        /// <param name="kilogram">The kilogram.</param>
        /// <returns></returns>
        public bool ConvertedKilogramToGramValue(Kilogram kilogram)
        {
            if (this.kilogram == 0 && this.gram == 0)
                return false;
            if (this.gram.Equals(kilogram.kilogram *1000))
                return true;
            
            return false;
        }
    }
}
