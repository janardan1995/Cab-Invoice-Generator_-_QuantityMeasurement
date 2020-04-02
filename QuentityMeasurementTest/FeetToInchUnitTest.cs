using NUnit.Framework;
using QuantityMeasurement;

namespace QuentityMeasurementTest
{
    public class Tests
    {
        [Test]
        public void Given_0Feet_And0Feet_ShouldReturnTrue()
        {
            Feet ft1 = new Feet(0);
            Feet ft2 = new Feet(0);
            var actual = ft1.ConvertedFeetValue(ft2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void Given_nullFeet_ShouldReturnFalse()
        {
            Feet ft1 = new Feet(11);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }

        [Test]
        public void ForFeet_RefCheck_ShouldReturnFalse()
        {
            Feet ft1 = new Feet(11);
            var actual = this.Equals(ft1);
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void ForFeet_TypeCheck_ShouldReturnTrue()
        {
            Feet ft1 = new Feet(11);
            Feet ft2 = new Feet(13);
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenSimilar_FeetValues_WhileCheking_ShouldReturnTrue()
        {
            Feet ft1 = new Feet(11);
            Feet ft2 = new Feet(11);
            var actual = ft1.ConvertedFeetValue(ft2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenOdd_FeetValues_WhileCheking_ShouldReturnFalse()
        {
            Feet ft1 = new Feet(11);
            Feet ft2 = new Feet(110);
            var actual = ft1.ConvertedFeetValue(ft2);
            Assert.IsFalse(actual);
        }

        [Test]
        public void Given_nullInch_ShouldReturnFalse()
        {
            Inch ft1 = new Inch(11);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }

        [Test]
        public void ForInch_RefCheck_ShouldReturnFalse()
        {
            Inch ft1 = new Inch(11);
            var actual = this.Equals(ft1);
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void ForInch_TypeCheck_ShouldReturnTrue()
        {
            Inch ft1 = new Inch(11);
            Inch ft2 = new Inch(13);
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenSimilar_InchValues_WhileCheking_ShouldReturnTrue()
        {
            Inch ft1 = new Inch(11);
            Inch ft2 = new Inch(11);
            var actual = ft1.ConvertedInchValue(ft2);
            Assert.IsTrue(actual);
        }
        [Test]
        public void GivenOdd_InchValues_WhileCheking_ShouldReturnFalse()
        {
            Inch ft1 = new Inch(11);
            Inch ft2 = new Inch(110);
            var actual = ft1.ConvertedInchValue(ft2);
            Assert.IsFalse(actual);
        }

        [Test]
        public void Given_0feetAnd0Inch_WhileCheking_ShouldReturnTrue()
        {
            Feet feet = new Feet(0);
            Inch inch = new Inch(0);

            FeetToInches feetToInches = new FeetToInches(feet, inch);
            var actual = feetToInches.ConvertedFeetToInchValue();
            Assert.IsTrue(actual);
        }

        [Test]
        public void Given_1feetAnd1Inch_WhileCheking_ShouldReturnFalse()
        {
            Feet feet = new Feet(1);
            Inch inch = new Inch(1);

            FeetToInches feetToInches = new FeetToInches(feet, inch);
            var actual = feetToInches.ConvertedFeetToInchValue();
            Assert.IsFalse(actual);
        }



    }
}