using System;

namespace QuantityMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            Feet ss = new Feet(0);
            Feet s = new Feet(0);

            bool x = ss.Equals(s);
            Console.WriteLine(x);
        }
    }
}
