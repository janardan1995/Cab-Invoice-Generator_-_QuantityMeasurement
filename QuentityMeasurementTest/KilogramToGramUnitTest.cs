// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KilogramToGramUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------


namespace QuentityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasure_Weight;

    /// <summary>
    /// KilogramToGramUnitTest class
    /// </summary>
    public class KilogramToGramUnitTest
    {
        /// <summary>
        /// Givens the 0 kilogram and0 kilogram should return true.
        /// </summary>
        [Test]
        public void Given_0Kilogram_And0Kilogram_ShouldReturnTrue()
        {
            Kilogram _kilogram = new Kilogram(0);
            Kilogram kilogram = new Kilogram(0);
            var actual = _kilogram.ConvertedKilogramValue(kilogram);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the null kilogram should return false.
        /// </summary>
        [Test]
        public void Given_nullKilogram_ShouldReturnFalse()
        {
            Kilogram _kilogram = new Kilogram(10);
            var actual = _kilogram.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Fors the kilogram reference check should return false.
        /// </summary>
        [Test]
        public void ForKilogram_RefCheck_ShouldReturnFalse()
        {
            Kilogram _kilogram = new Kilogram(10);
            var actual = _kilogram.Equals(null);
            Assert.IsFalse(actual);

        }

        /// <summary>
        /// Fors the kilogram type check should return true.
        /// </summary>
        [Test]
        public void ForKilogram_TypeCheck_ShouldReturnTrue()
        {
            Kilogram _kilogram = new Kilogram(0);
            Kilogram kilogram = new Kilogram(0);
            var actual = _kilogram.Equals(kilogram);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the similar kilogram values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_KilogramValues_WhileCheking_ShouldReturnTrue()
        {
            Kilogram _kilogram = new Kilogram(10);
            Kilogram kilogram = new Kilogram(10);
            var actual = _kilogram.ConvertedKilogramValue(kilogram);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the odd kilogram values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_KilogramValues_WhileCheking_ShouldReturnFalse()
        {
            Kilogram _kilogram = new Kilogram(10);
            Kilogram kilogram = new Kilogram(1);
            var actual = _kilogram.ConvertedKilogramValue(kilogram);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the null gram k should return false.
        /// </summary>
        [Test]
        public void Given_nullGramK_ShouldReturnFalse()
        {
            Gram gram = new Gram(10);
            var actual = gram.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Fors the gram reference check should return false.
        /// </summary>
        [Test]
        public void ForGram_RefCheck_ShouldReturnFalse()
        {
            Gram gram = new Gram(10);
            var actual = gram.Equals(null);
            Assert.IsFalse(actual);

        }

        /// <summary>
        /// Fors the gram type check should return true.
        /// </summary>
        [Test]
        public void ForGram_TypeCheck_ShouldReturnTrue()
        {
            Gram gram = new Gram(0);
            Gram _gram = new Gram(0);
            var actual = gram.Equals(_gram);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the similar gram values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_GramValues_WhileCheking_ShouldReturnTrue()
        {
            Gram gram = new Gram(10);
            Gram _gram = new Gram(10);
            var actual = gram.ConvertedGramValue(_gram);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the odd gram values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_GramValues_WhileCheking_ShouldReturnFalse()
        {
            Gram gram = new Gram(10);
            Gram _gram = new Gram(1);
            var actual = gram.ConvertedGramValue(_gram);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the 0gram and0 kilogram while cheking should return false.
        /// </summary>
        [Test]
        public void Given_0gramAnd0Kilogram_WhileCheking_ShouldReturnFalse()
        {
            Gram gram = new Gram(0);
            Kilogram kilogram = new Kilogram(0);

            KilogramToGram kilogramToGram = new KilogramToGram(kilogram, gram);
            var actual = kilogramToGram.ConvertedKilogramToGramValue(kilogram);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the 1gram and1 kilogram while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1gramAnd1Kilogram_WhileCheking_ShouldReturnFalse()
        {
            Gram gram = new Gram(1);
            Kilogram kilogram = new Kilogram(1);

            KilogramToGram kilogramToGram = new KilogramToGram(kilogram, gram);
            var actual = kilogramToGram.ConvertedKilogramToGramValue(kilogram);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the 1000gram 1 kilogram while cheking should return true.
        /// </summary>
        [Test]
        public void Given_1000gram_1Kilogram_WhileCheking_ShouldReturnTrue()
        {
            Gram gram = new Gram(1000);
            Kilogram kilogram = new Kilogram(1);

            KilogramToGram kilogramToGram = new KilogramToGram(kilogram, gram);
            var actual = kilogramToGram.ConvertedGramToKilogramValue(gram);
            Assert.IsTrue(actual);
        }
    }
}
