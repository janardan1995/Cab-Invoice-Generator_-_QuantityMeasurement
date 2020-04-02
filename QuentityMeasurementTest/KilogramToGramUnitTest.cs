using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuantityMeasure_Weight;

namespace QuentityMeasurementTest
{
    public class KilogramToGramUnitTest
    {
        [Test]
        public void Given_0Kilogram_And0Kilogram_ShouldReturnTrue()
        {
            Kilogram ft1 = new Kilogram(0);
            Kilogram ft2 = new Kilogram(0);
            var actual = ft1.ConvertedKilogramValue(ft2);
            Assert.IsTrue(actual);
        }


        [Test]
        public void Given_nullKilogram_ShouldReturnFalse()
        {
            Kilogram ft1 = new Kilogram(10);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }


        [Test]
        public void ForKilogram_RefCheck_ShouldReturnFalse()
        {
            Kilogram ft1 = new Kilogram(10);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
            
        }


        [Test]
        public void ForKilogram_TypeCheck_ShouldReturnTrue()
        {
            Kilogram ft1 = new Kilogram(0);
            Kilogram ft2 = new Kilogram(0);            
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }


        [Test]
        public void GivenSimilar_KilogramValues_WhileCheking_ShouldReturnTrue()
        {
            Kilogram ft1 = new Kilogram(10);
            Kilogram ft2 = new Kilogram(10);
            var actual = ft1.ConvertedKilogramValue(ft2);
            Assert.IsTrue(actual);
        }


        [Test]
        public void GivenOdd_KilogramValues_WhileCheking_ShouldReturnFalse()
        {
            Kilogram ft1 = new Kilogram(10);
            Kilogram ft2 = new Kilogram(1);
            var actual = ft1.ConvertedKilogramValue(ft2);
            Assert.IsFalse(actual);
        }

        
        [Test]
        public void Given_nullGramK_ShouldReturnFalse()
        {
            Gram ft1 = new Gram(10);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
        }


        [Test]
        public void ForGram_RefCheck_ShouldReturnFalse()
        {
            Gram ft1 = new Gram(10);
            var actual = ft1.Equals(null);
            Assert.IsFalse(actual);
            
        }


        [Test]
        public void ForGram_TypeCheck_ShouldReturnTrue()
        {
            Gram ft1 = new Gram(0);
            Gram ft2 = new Gram(0);            
            var actual = ft1.Equals(ft2);
            Assert.IsTrue(actual);
        }


        [Test]
        public void GivenSimilar_GramValues_WhileCheking_ShouldReturnTrue()
        {
            Gram ft1 = new Gram(10);
            Gram ft2 = new Gram(10);
            var actual = ft1.ConvertedGramValue(ft2);
            Assert.IsTrue(actual);
        }


        [Test]
        public void GivenOdd_GramValues_WhileCheking_ShouldReturnFalse()
        {
            Gram ft1 = new Gram(10);
            Gram ft2 = new Gram(1);
            var actual = ft1.ConvertedGramValue(ft2);
            Assert.IsFalse(actual);
        }


        [Test]
        public void Given_0gramAnd0Kilogram_WhileCheking_ShouldReturnFalse()
        {
            Gram gram = new Gram(0);
            Kilogram kilogram = new Kilogram(0);

            KilogramToGram kilogramToGram = new KilogramToGram(kilogram,gram);
            var actual = kilogramToGram.ConvertedKilogramToGramValue(kilogram);
            Assert.IsFalse(actual);
        }


        [Test]
        public void Given_1gramAnd1Kilogram_WhileCheking_ShouldReturnFalse()
        {
            Gram gram = new Gram(1);
            Kilogram kilogram = new Kilogram(1);

            KilogramToGram kilogramToGram = new KilogramToGram(kilogram, gram);
            var actual = kilogramToGram.ConvertedKilogramToGramValue(kilogram);
            Assert.IsFalse(actual);
        }


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
