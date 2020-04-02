// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CelsiusToFarhenheithUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuentityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement_TemperatureCalculation;

    /// <summary>
    /// CelsiusToFarhenheithUnitTest class
    /// /// </summary>
    public class CelsiusToFarhenheithUnitTest
    {
        /// <summary>
        /// Givens the 0 celsius and0 celsius should return true.
        /// </summary>
        [Test]
        public void Given_0Celsius_And0Celsius_ShouldReturnTrue()
        {
            Celsius ft1 = new Celsius(0);
            Celsius ft2 = new Celsius(0);
            var actual = ft1.ConvertedCelsiusValue(ft2);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the null celsius should return false.
        /// </summary>
        [Test]
        public void Given_nullCelsius_ShouldReturnFalse()
        {
            Celsius ft1 = new Celsius(11);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Fors the celsius reference check should return false.
        /// </summary>
        [Test]
        public void ForCelsius_RefCheck_ShouldReturnFalse()
        {
            Celsius ft1 = new Celsius(11);
            var actual = this.Equals(ft1);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Fors the celsius type check should return true.
        /// </summary>
        [Test]
        public void ForCelsius_TypeCheck_ShouldReturnTrue()
        {
            Celsius ft1 = new Celsius(11);
            Celsius ft2 = new Celsius(11);
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the similar celsius values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_CelsiusValues_WhileCheking_ShouldReturnTrue()
        {
            Celsius ft1 = new Celsius(11);
            Celsius ft2 = new Celsius(11);
            var actual = ft1.ConvertedCelsiusValue(ft2);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the odd celsius values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_CelsiusValues_WhileCheking_ShouldReturnFalse()
        {
            Celsius ft1 = new Celsius(11);
            Celsius ft2 = new Celsius(110);
            var actual = ft1.ConvertedCelsiusValue(ft2);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the null fahrenheith should return false.
        /// </summary>
        [Test]
        public void Given_nullFahrenheith_ShouldReturnFalse()
        {
            Fahrenheith ft1 = new Fahrenheith(11);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Fors the fahrenheith reference check should return false.
        /// </summary>
        [Test]
        public void ForFahrenheith_RefCheck_ShouldReturnFalse()
        {
            Fahrenheith ft1 = new Fahrenheith(11);
            var actual = this.Equals(ft1);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Fors the fahrenheith type check should return true.
        /// </summary>
        [Test]
        public void ForFahrenheith_TypeCheck_ShouldReturnTrue()
        {
            Fahrenheith ft1 = new Fahrenheith(11);
            Fahrenheith ft2 = new Fahrenheith(13);
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the similar fahrenheith values while cheking should return true.
        /// </summary>
        [Test]
        public void GivenSimilar_FahrenheithValues_WhileCheking_ShouldReturnTrue()
        {
            Fahrenheith ft1 = new Fahrenheith(11);
            Fahrenheith ft2 = new Fahrenheith(11);
            var actual = ft1.ConvertedFahrenheithValue(ft2);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the odd fahrenheith values while cheking should return false.
        /// </summary>
        [Test]
        public void GivenOdd_FahrenheithValues_WhileCheking_ShouldReturnFalse()
        {
            Fahrenheith ft1 = new Fahrenheith(11);
            Fahrenheith ft2 = new Fahrenheith(110);
            var actual = ft1.ConvertedFahrenheithValue(ft2);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the 0 fahrenheith and0 celsius while cheking should return false.
        /// </summary>
        [Test]
        public void Given_0FahrenheithAnd0Celsius_WhileCheking_ShouldReturnFalse()
        {
            Fahrenheith fahrenheith = new Fahrenheith(0);
            Celsius celsius = new Celsius(0);

            CelsiusToFahrenheith CelsiusToFahrenheith = new CelsiusToFahrenheith(celsius, fahrenheith);
            var actual = CelsiusToFahrenheith.ConvertedCelsiusToFarhenheithValue(celsius);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the 1 fahrenheith and1 celsius while cheking should return false.
        /// </summary>
        [Test]
        public void Given_1FahrenheithAnd1Celsius_WhileCheking_ShouldReturnFalse()
        {
            Fahrenheith fahrenheith = new Fahrenheith(1);
            Celsius celsius = new Celsius(1);

            CelsiusToFahrenheith CelsiusToFahrenheith = new CelsiusToFahrenheith(celsius, fahrenheith);
            var actual = CelsiusToFahrenheith.ConvertedCelsiusToFarhenheithValue(celsius);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Givens the 32 fahrenheith 0 celsius while cheking should return true.
        /// </summary>
        [Test]
        public void Given_32Fahrenheith_0Celsius_WhileCheking_ShouldReturnTrue()
        {
            Fahrenheith fahrenheith = new Fahrenheith(32);
            Celsius celsius = new Celsius(0);

            CelsiusToFahrenheith CelsiusToFahrenheith = new CelsiusToFahrenheith(celsius, fahrenheith);
            var actual = CelsiusToFahrenheith.ConvertedCelsiusToFarhenheithValue(celsius);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Givens the fahrenheith celsius while cheking should return false.
        /// </summary>
        [Test]
        public void Given_Fahrenheith_Celsius_WhileCheking_ShouldReturnFalse()
        {

            Fahrenheith fahrenheith = new Fahrenheith(212);
            Celsius celsius = new Celsius(100);

            CelsiusToFahrenheith CelsiusToFahrenheith = new CelsiusToFahrenheith(celsius, fahrenheith);
            var actual = CelsiusToFahrenheith.ConvertedFarhenheithTocelsiusValue(fahrenheith);
            Assert.IsTrue(actual);
        }       
    }
}
