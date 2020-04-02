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
    }
}