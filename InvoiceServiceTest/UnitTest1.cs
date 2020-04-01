// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace InvoiceServiceTest
{
    using System.Collections.Generic;
    using CabInvoiceService;
    using NUnit.Framework;

    /// <summary>
    /// InvoiceService All test cases
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Givens the distance and time should return total fare.
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            double distance = 0.2;
            int time = 3;
            InvoiceService obj = new InvoiceService();
            double actual = obj.CalculateFare(distance, time);
            double expected = obj.CalculateFare(0.2, 3);
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Invoices the generator should takes multiple ride should return total fare.
        /// </summary>
        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnTotalFare()
        {
            Ride[] rides =
                {
                new Ride(5,15),
                new Ride(12,35),
                new Ride(7,23)
            };

            InvoiceService obj = new InvoiceService();
            double Actual = obj.totalFare(rides);
            double expected = obj.CalculateFare(5, 15) + obj.CalculateFare(12, 35) + obj.CalculateFare(7, 23);
            Assert.AreEqual(Actual, expected);
        }

        /// <summary>
        /// Invoices the generator should takes multiple ride should return total no of rides.
        /// </summary>
        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnTotalNoOfRides()
        {
            Ride[] rides =
                {
                new Ride(5,15),
                new Ride(12,35),
                new Ride(7,23)
            };

            InvoiceService obj = new InvoiceService();
            double Actual = obj.TotalRides(rides);
            double expected = rides.Length;
            Assert.AreEqual(Actual, expected);
        }

        /// <summary>
        /// Invoices the generator should takes multiple ride should return average fare per ride.
        /// </summary>
        [Test]
        public void InvoiceGeneratorShouldTakesMultipleRide_ShouldReturnAverageFarePerRide()
        {
            Ride[] rides =
                {
                new Ride(5,15),
                new Ride(12,35),
                new Ride(7,23)
            };

            InvoiceService obj = new InvoiceService();
            double Actual = obj.AverageFareForEachRides(rides);
            double Total = obj.CalculateFare(5, 15) + obj.CalculateFare(12, 35) + obj.CalculateFare(7, 23);
            double expected = Total / rides.Length;
            Assert.AreEqual(Actual, expected);
        }

        /// <summary>
        /// Givens the user identifier should get total fare.
        /// </summary>
        [Test]
        public void Given_UserId_ShouldGet_TotalFare()
        {
            RideRepository rideRepository = new RideRepository();
            List<Ride> rides = new List<Ride>();
            rides.Add(new Ride(5, 15));
            rides.Add(new Ride(12, 35));
            rides.Add(new Ride(7, 23));
            
            Customer New_Custmor = new Customer("jd");
            rideRepository.AddRide(New_Custmor,rides);

            InvoiceService obj = new InvoiceService();
            double actual = obj.GetInvoiceSummary(New_Custmor);
            double expected = obj.totalFare(rides.ToArray());
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Givens the user identifier should get total number of rides.
        /// </summary>
        [Test]
        public void Given_UserId_ShouldGet_TotalNumberOfRides()
        {
            List<Ride> rides = new List<Ride>();
            rides.Add(new Ride(5, 15));
            rides.Add(new Ride(12, 35));
            rides.Add(new Ride(7, 23));
            
            Customer New_Custmor = new Customer("jd");
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRide(New_Custmor, rides);
            double actual = InvoiceSummary.GetRides(New_Custmor);

            InvoiceService obj = new InvoiceService();
            double expected = obj.TotalRides(rides.ToArray());
            Assert.AreEqual(actual, expected);
        }
    }
}