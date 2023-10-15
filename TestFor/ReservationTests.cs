using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinjaUnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});
            // Assert
            Assert.IsTrue(result);  


        }
    }
}
