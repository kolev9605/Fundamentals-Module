namespace HotelBookingSystem.Tests
{
    using System;
    using Controllers;
    using Data;
    using Identity;
    using Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;

    [TestClass]
    public class ControllerTests
    {
        private IHotelBookingSystemData db;
        private User firstUser;
        private VenuesController venuesController;

        [TestInitialize]
        public void InitController()
        {
            this.db = new HotelBookingSystemData();
        }

        [TestMethod]
        [ExpectedException(typeof(AuthorizationFailedException))]
        public void TestAuthorize_WithInvalidPremission_ShouldThrowException()
        {
            this.firstUser = new User("Pesho", "sdqwe123", Roles.User);
            this.venuesController = new VenuesController(this.db, this.firstUser);

            this.venuesController.Add("Zdrrrrrr", "Zdrrrr", "Nqmam opisanie");
        }

        [TestMethod]
        public void TestAuthorize_WithValidPremission_ShouldPass()
        {
            this.firstUser = new User("Pesho", "sdqwe123", Roles.VenueAdmin);
            this.venuesController = new VenuesController(this.db, this.firstUser);

            this.venuesController.Add("Zdrrrrrr", "Zdrrrr", "Nqmam opisanie");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAuthorize_WithoutLoggedUser_ShouldThrowException()
        {
            this.firstUser = null;
            this.venuesController = new VenuesController(this.db, this.firstUser);

            this.venuesController.Add("Zdrrrrrr", "Zdrrrr", "Nqmam opisanie");
        }
    }
}
