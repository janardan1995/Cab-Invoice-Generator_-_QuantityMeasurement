// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceSummary.cs" company="Bridgelabz">
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
    /// Invoice class 
    /// </summary>
    public class InvoiceSummary
    {
        /// <summary>
        /// Gets or sets the number rides.
        /// </summary>
        /// <value>
        /// The number rides.
        /// </value>
        public int Number_Rides { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummary"/> class.
        /// </summary>
        /// <param name="Number_Rides">The number rides.</param>
        public InvoiceSummary(int Number_Rides)
        {
            this.Number_Rides = Number_Rides;
        }

        /// <summary>
        /// Gets the rides.
        /// </summary>
        /// <param name="User_Id">The user identifier.</param>
        /// <returns></returns>
        public static int GetRides(Customer User_Id)
        {
            foreach (KeyValuePair<Customer, List<Ride>> keyvalues in RideRepository.RideDictionary)
            {
                if (User_Id == keyvalues.Key)
                {
                    return keyvalues.Value.Count;
                }
            }
            return 0;
        }
    }
}
