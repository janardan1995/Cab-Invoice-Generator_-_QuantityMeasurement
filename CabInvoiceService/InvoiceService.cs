namespace CabInvoiceService
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InvoiceService
    {
        private static readonly int COST_PER_TIME = 1;
        private static readonly double MINIMUM_COST_PER_KILOMETER = 10;
        private static readonly double MINIMUM_FARE = 5;


        public double CalculateFare(double Distance, double time)
        {
            double TotalFare = Distance * MINIMUM_COST_PER_KILOMETER + time * COST_PER_TIME;
            return Math.Max(TotalFare, MINIMUM_FARE);
        }

    }
}
