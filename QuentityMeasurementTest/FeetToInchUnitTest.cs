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
        public void Given_Ref_ShouldReturnFalse()
        {
            Feet ft1 = new Feet(11);
            var actual = ft1.Equals(this);
            Assert.IsFalse(actual);
        }

    }
}