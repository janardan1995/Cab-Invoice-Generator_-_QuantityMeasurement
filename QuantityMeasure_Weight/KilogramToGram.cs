
namespace QuantityMeasure_Weight
{
    public class KilogramToGram
    {
        public double kilogram;
        public double gram;
        public KilogramToGram(Kilogram kilogram, Gram gram)
        {
            this.kilogram = kilogram.kilogram;
            this.gram = gram.gram;
        }

        public bool ConvertedGramToKilogramValue(Gram gram)
        {           
            if (this.kilogram == 0 && this.gram == 0)
                return false;
            if (this.kilogram.Equals(gram.gram/1000))
                return true;

            return false;
        }

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
