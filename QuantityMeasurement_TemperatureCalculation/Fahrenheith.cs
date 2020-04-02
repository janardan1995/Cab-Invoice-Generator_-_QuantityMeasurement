using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_TemperatureCalculation
{
    public class Fahrenheith
    {
        public double fahrenheith;
        public Fahrenheith(double fahrenheith)
        {
            this.fahrenheith = fahrenheith;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        public bool ConvertedFahrenheithValue(Fahrenheith fahrenheith)
        {
            if (this.fahrenheith.Equals(fahrenheith.fahrenheith))
                return true;
            return false;
        }
    }
}
