// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetToInchesUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------


namespace QuentityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// Feet into inches test class
    /// </summary>
    public class FeetToInchesUnitTest
    {
        /// <summary>
        /// TestCase 1
        /// Givens the 0 feet and0 feet should return true.
        /// </summary>
        [Test]
        public void Given_0Feet_And0Feet_ShouldReturnTrue()
        {
            Feet feet = new Feet(0);
            Feet _feet = new Feet(0);
            var actual = feet.ConvertedFeetValue(_feet);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 2
        /// Givens the null feet should return false.
        /// </summary>
        [Test]
        public void Given_nullFeet_ShouldReturnFalse()
        {
            Feet _feet = new Feet(11);
            var actual = _feet.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 3
        /// Fors the feet reference check should return false.
        /// </summary>
        [Test]
        public void ForFeet_RefCheck_ShouldReturnFalse()
        {
            Feet _feet = new Feet(11);
            var actual = this.Equals(_feet);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 4
        /// Fors the feet type check should return true.
        /// </summary>
        [Test]
        public void ForFeet_TypeCheck_ShouldReturnTrue()
        {
            Feet _feet = new Feet(11);
            Feet feet = new Feet(13);
            var actual = _feet.Equals(feet);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 5
        /// Givens the similar feet values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_FeetValues_WhileCheking_ShouldReturnTrue()
        {
            Feet _feet = new Feet(11);
            Feet feet = new Feet(11);
            var actual = _feet.ConvertedFeetValue(feet);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 6
        /// Givens the odd feet values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_FeetValues_WhileCheking_ShouldReturnFalse()
        {
            Feet _feet = new Feet(11);
            Feet feet = new Feet(110);
            var actual = _feet.ConvertedFeetValue(feet);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 7
        /// Givens the null inch should return false.
        /// </summary>
        [Test]
        public void Given_nullInch_ShouldReturnFalse()
        {
            Inch _inch = new Inch(11);
            var actual = _inch.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 8
        /// Fors the inch reference check should return false.
        /// </summary>
        [Test]
        public void ForInch_RefCheck_ShouldReturnFalse()
        {
            Inch inch = new Inch(11);
            var actual = this.Equals(inch);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 9
        /// Fors the inch type check should return true.
        /// </summary>
        [Test]
        public void ForInch_TypeCheck_ShouldReturnTrue()
        {
            Inch _inch = new Inch(11);
            Inch inch = new Inch(13);
            var actual = _inch.Equals(inch);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 10
        /// Givens the similar inch values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_InchValues_WhileCheking_ShouldReturnTrue()
        {
            Inch _inch = new Inch(11);
            Inch inch = new Inch(11);
            var actual = _inch.ConvertedInchValue(inch);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 11
        /// Givens the odd inch values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_InchValues_WhileCheking_ShouldReturnFalse()
        {
            Inch _inch = new Inch(11);
            Inch inch = new Inch(110);
            var actual = _inch.ConvertedInchValue(inch);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 12
        /// Givens the 0feet and0 inch while cheking should return true.
        /// </summary>
        [Test]
        public void Given_0feetAnd0Inch_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(0);
            Inch inch = new Inch(0);

            FeetToInches feetToInches = new FeetToInches(feet, inch);
            var actual = feetToInches.ConvertedFeetToInchValue(inch);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 13
        /// Givens the 1feet and1 inch while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1feetAnd1Inch_WhileCheking_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Inch inch = new Inch(1);

            FeetToInches feetToInches = new FeetToInches(feet, inch);
            var actual = feetToInches.ConvertedFeetToInchValue(inch);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 14
        /// Givens the 1feet 12 inch while cheking should return true.
        /// </summary>
        [Test]
        public void Given_1feet_12Inch_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(1);
            Inch inch = new Inch(12);

            FeetToInches feetToInches = new FeetToInches(feet, inch);
            var actual = feetToInches.ConvertedFeetToInchValue(inch);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 15
        /// Givens the 1 inch 1feet while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1Inch_1feet_WhileCheking_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Inch inch = new Inch(1);

            FeetToInches feetToInches = new FeetToInches(feet, inch);
            var actual = feetToInches.ConvertedInchToFeetValue(feet);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 16
        /// Givens the 12 inch 1feet while cheking should return true.
        /// </summary>
        [Test]
        public void Given_12Inch_1feet_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(1);
            Inch inch = new Inch(12);

            FeetToInches feetToInches = new FeetToInches(feet,inch);
            var actual = feetToInches.ConvertedInchToFeetValue(feet);
            Assert.IsTrue(actual);
        }
    }
}