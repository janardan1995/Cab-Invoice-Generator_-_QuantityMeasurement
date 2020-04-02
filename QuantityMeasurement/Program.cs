using System;

namespace QuantityMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            Feet ss = new Feet(0);
            

            bool x = ss.Equals(ss);
            Console.WriteLine(x);
        }
    }
}
