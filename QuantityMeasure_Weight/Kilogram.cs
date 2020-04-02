using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasure_Weight
{
    public class Kilogram
    {
        public double kilogram;
        public Kilogram(double kilogram)
        {
            this.kilogram = kilogram;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        public bool ConvertedKilogramValue(Kilogram kilogram)
        {
            if (this.kilogram.Equals(kilogram.kilogram))
                return true;
            return false;
        }
    }
}
