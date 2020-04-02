using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasure_Weight
{
    public class Gram
    {
        public double gram;
        public Gram(double celsius)
        {
            this.gram = celsius;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        public bool ConvertedGramValue(Gram celsius)
        {
            if (this.gram.Equals(celsius.gram))
                return true;
            return false;
        }
    }
}
