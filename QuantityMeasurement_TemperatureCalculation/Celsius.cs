using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_TemperatureCalculation
{
    public class Celsius
    {
        public double celsius;
        public Celsius(double celsius)
        {
            this.celsius = celsius;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }

        public bool ConvertedCelsiusValue(Celsius celsius)
        {
            if (this.celsius.Equals(celsius.celsius))
                return true;
            return false;
        }
    }
}
