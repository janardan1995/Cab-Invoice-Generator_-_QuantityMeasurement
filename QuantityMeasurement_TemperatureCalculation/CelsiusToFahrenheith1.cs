using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_TemperatureCalculation
{
    public class CelsiusToFahrenheith
    {
        public double celsius;
        public double fahrenheith;
        public CelsiusToFahrenheith(Celsius celsius, Fahrenheith fahrenheith)
        {
            this.celsius = celsius.celsius;
            this.fahrenheith = fahrenheith.fahrenheith;
        }

        public bool ConvertedFarhenheithTocelsiusValue(Fahrenheith fahrenheith)
        {
           
            if (this.celsius == 0 && this.fahrenheith == 0)
                return false;
            if (this.celsius.Equals((fahrenheith.fahrenheith - 32) / 1.8000))
                return true;

            return false;
        }

        public bool ConvertedCelsiusToFarhenheithValue(Celsius celsius)
        {           
            
            if (this.fahrenheith.Equals(celsius.celsius * 9 / 5 + 32))
                return true;
            
            return false;
        }

    }
}
