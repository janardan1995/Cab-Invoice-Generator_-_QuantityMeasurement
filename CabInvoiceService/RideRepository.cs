using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceService
{

    public class RideRepository
    {
        public static Dictionary<Customer, List<Ride>> RideDictionary = null;
        public RideRepository()
        {
            RideDictionary = new Dictionary<Customer, List<Ride>>();
        }

        public void AddRide( Customer custmerId, List<Ride> rides)
        {
            RideDictionary.Add(custmerId, rides);
        }
    }

}

