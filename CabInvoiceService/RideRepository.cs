// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RideRepository.cs" company="Bridgelabz">
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
    /// Repository class
    /// </summary>
    public class RideRepository
    {
        /// <summary>
        /// The ride dictionary
        /// </summary>
        public static Dictionary<Customer, List<Ride>> RideDictionary = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RideRepository"/> class.
        /// </summary>
        public RideRepository()
        {
            RideDictionary = new Dictionary<Customer, List<Ride>>();
        }

        /// <summary>
        /// Adds the ride.
        /// </summary>
        /// <param name="custmerId">The custmer identifier.</param>
        /// <param name="rides">The rides.</param>
        public void AddRide( Customer custmerId, List<Ride> rides)
        {
            RideDictionary.Add(custmerId, rides);
        }
    }

}

