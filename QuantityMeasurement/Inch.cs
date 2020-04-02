using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Inch
    {
        public double inch;
        public Inch(double inch)
        {
            this.inch = inch;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        public bool ConvertedInchValue(Inch inch)
        {
            if (this.inch.Equals(inch.inch))
                return true;
            return false;
        }
    }
}
