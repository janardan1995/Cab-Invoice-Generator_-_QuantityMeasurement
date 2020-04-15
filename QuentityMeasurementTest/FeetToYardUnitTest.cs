// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetToYardUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuentityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// FeetToYardUnitTest
    /// </summary>
    public class FeetToYardUnitTest
    {
        /// <summary>
        /// TestCase 1
        /// Givens the 0yard and0yard should return true.
        /// </summary>
        [Test]
        public void Given_0yard_And0yard_ShouldReturnTrue()
        {
            Yard yard = new Yard(0);
            Yard _yard = new Yard(0);
            var actual = yard.ConvertedYardValue(_yard);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 2
        /// Givens the null yard should return false.
        /// </summary>
        [Test]
        public void Given_nullYard_ShouldReturnFalse()
        {
            Yard _yard = new Yard(11);
            var actual = _yard.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 3
        /// Fors the yard reference check should return false.
        /// </summary>
        [Test]
        public void ForYard_RefCheck_ShouldReturnFalse()
        {
            Yard _yard = new Yard(11);
            var actual = this.Equals(_yard);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 4
        /// Fors the yard type check should return true.
        /// </summary>
        [Test]
        public void ForYard_TypeCheck_ShouldReturnTrue()
        {
            Yard _yard = new Yard(11);
            Yard yard = new Yard(13);
            var actual = _yard.Equals(yard);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 5
        /// Givens the similar yard values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_YardValues_WhileCheking_ShouldReturnTrue()
        {
            Yard _yard = new Yard(11);
            Yard yard = new Yard(11);
            var actual = _yard.ConvertedYardValue(yard);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 6
        /// Givens the odd yard values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_YardValues_WhileCheking_ShouldReturnFalse()
        {
            Yard _yard = new Yard(11);
            Yard yard = new Yard(110);
            var actual = _yard.ConvertedYardValue(yard);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 7
        /// Givens the 0feet and0 inch while cheking should return true.
        /// </summary>
        [Test]
        public void Given_0feetAnd0Inch_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(0);
            Yard yard = new Yard(0);

            FeetToYard feetToInches = new FeetToYard(feet, yard);
            var actual = feetToInches.ConvertedFeetToYardValue(yard);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 8
        /// Givens the 1feet and1 yard while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1feetAnd1Yard_WhileCheking_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Yard yard = new Yard(1);

            FeetToYard feetToYard = new FeetToYard(feet, yard);
            var actual = feetToYard.ConvertedFeetToYardValue(yard);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 8
        /// Givens the 3feet 1 yard while cheking should return true.
        /// </summary>
        [Test]
        public void Given_3feet_1Yard_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(3);
            Yard yard = new Yard(1);

            FeetToYard feetToYard = new FeetToYard(feet, yard);
            var actual = feetToYard.ConvertedFeetToYardValue(yard);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 9
        /// Givens the 3 yard 1feet while cheking should return false.
        /// </summary>
        [Test]
        public void Given_3Yard_1feet_WhileCheking_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Yard yard = new Yard(3);

            FeetToYard feetToYard = new FeetToYard(feet, yard);
            var actual = feetToYard.ConvertedFeetToYardValue(yard);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 10
        /// Givens the 1 yard 1feet while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1Yard_1feet_WhileCheking_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Yard yard = new Yard(1);

            FeetToYard feetToYard = new FeetToYard(feet, yard);
            var actual = feetToYard.ConvertedYardToFeetValue(feet);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 11
        /// Givens the 1 yard 3feet while cheking should return true.
        /// </summary>
        [Test]
        public void Given_1Yard_3feet_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(3);
            Yard yard = new Yard(1);

            FeetToYard feetToYard = new FeetToYard(feet, yard);
            var actual = feetToYard.ConvertedYardToFeetValue(feet);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 12
        /// Givens the 1 yard 1 inch while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1Yard_1Inch_WhileCheking_ShouldReturnFalse()
        {
            Inch inch = new Inch(1);
            Yard yard = new Yard(36);

            InchToYard inchToYard = new InchToYard(inch, yard);
            var actual = inchToYard.ConvertedYardToInchValue(yard);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// TestCase 13
        /// Givens the 1 yard 36 inches while cheking should return true.
        /// </summary>
        [Test]
        public void Given_1Yard_36Inches_WhileCheking_ShouldReturnTrue()
        {
            Inch inch = new Inch(36);
            Yard yard = new Yard(1);

            InchToYard inchToYard = new InchToYard(inch, yard);
            var actual = inchToYard.ConvertedYardToInchValue(yard);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// TestCase 14
        /// Givens the 36 yards 1 inch while cheking should return false.
        /// </summary>
        [Test]
        public void Given_36Yards_1Inch_WhileCheking_ShouldReturnFalse()
        {
            Inch inch = new Inch(1);
            Yard yard = new Yard(36);

            InchToYard inchToYard = new InchToYard(inch, yard);
            var actual = inchToYard.ConvertedYardToInchValue(yard);
            Assert.IsFalse(actual);
        }
    }
}
