using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class FeetToInches
    {

        public double feet;
        public double inch;
        public FeetToInches(Feet feet, Inch inch)
        {
            this.feet = feet.feet;
            this.inch = inch.inch;

        }

        public bool ConvertedFeetToInchValue()
        {
            if (this.feet == 0 && (this.feet.Equals(this.inch)))
                return true;           
            return false;
        }
    }
}
