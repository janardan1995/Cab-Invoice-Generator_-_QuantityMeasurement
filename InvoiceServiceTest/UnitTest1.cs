namespace InvoiceServiceTest
{
    using CabInvoiceService;
    using NUnit.Framework;

    public class Tests
    {
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
    }
}