using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class BookingHelper_OverlappingBookingsExistTests
    {
        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingBooking_ReturnEmptyString()
        {
            var mock = new Mock<IBookingRepository>();
            
        }
        
    }
}