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

        public bool ConvertedFeetToInchValue(Inch inch)
        {

            if (this.feet == 0 && (this.feet.Equals(inch.inch)))
                return true;
            if ((this.feet.Equals(inch.inch/12)))
                return true;
            return false;
        }  
            
          public bool ConvertedInchToFeetValue(Feet feet)
        {

            if (this.feet == 0 && (this.inch.Equals(feet.feet)))
                return true;
            if ((this.inch.Equals(12 * feet.feet)))
                return true;
            return false;
        } 
    }
}
