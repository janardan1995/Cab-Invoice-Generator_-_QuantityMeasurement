// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceService.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace CabInvoiceService
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InvoiceService Class 
    /// </summary>
    public class InvoiceService
    {
        /// <summary>
        /// The cost per time
        /// </summary>
        private static readonly int COST_PER_TIME = 1;

        /// <summary>
        /// The minimum cost per kilometer
        /// </summary>
        private static readonly double MINIMUM_COST_PER_KILOMETER = 10;

        /// <summary>
        /// The minimum fare
        /// </summary>
        private static readonly double MINIMUM_FARE = 5;

        /// <summary>
        /// Calculates the fare.
        /// </summary>
        /// <param name="Distance">The distance.</param>
        /// <param name="time">The time.</param>
        /// <returns>double value </returns>
        public double CalculateFare(double Distance, double time)
        {
            double TotalFare = Distance * MINIMUM_COST_PER_KILOMETER + time * COST_PER_TIME;
            return Math.Max(TotalFare, MINIMUM_FARE);
        }

        /// <summary>
        /// Totals the fare.
        /// </summary>
        /// <param name="rides">The rides.</param>
        /// <returns>double value</returns>
        public double totalFare(Ride[] rides)
        {
            double TotalFare = 0;
            //InvoiceService obj1 = new InvoiceService();
            foreach (Ride ride in rides)
            {
                TotalFare += CalculateFare(ride.Distance, ride.time);
            }
            return TotalFare;
        }

    }
}
