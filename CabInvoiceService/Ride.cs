// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ride.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace CabInvoiceService
{
    /// <summary>
    /// 
    /// </summary>
    public class Ride
    {
        /// <summary>
        /// The distance
        /// </summary>
        public double Distance;

        /// <summary>
        /// The time
        /// </summary>
        public double time;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ride"/> class.
        /// </summary>
        /// <param name="Distance">The distance.</param>
        /// <param name="time">The time.</param>
        public Ride(double Distance, double time)
        {
            this.Distance = Distance;
            this.time = time;
        }
    }
}
