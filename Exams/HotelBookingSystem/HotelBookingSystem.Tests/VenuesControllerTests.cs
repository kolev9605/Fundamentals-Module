namespace HotelBookingSystem.Tests
{
    using Controllers;
    using Data;
    using Identity;
    using Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;

    [TestClass]
    public class VenuesControllerTests
    {
        private IHotelBookingSystemData data;
        private User user;
        private VenuesController venuesController;

        [TestInitialize]
        public void InitObjects()
        {
            this.data = new HotelBookingSystemData();
        }

        [TestMethod]
        public void TestAll_WithPresentVenuesAndValidPremissions_ShouldPass()
        {
            const string ExpectedResult = @"*[1] Venu1, located at Address1
Free rooms: 0
*[2] Venu2, located at Address2
Free rooms: 0
*[3] Venu2, located at Address2
Free rooms: 0";

            this.user = new User("Pesho", "asdasd", Roles.VenueAdmin);

            this.venuesController = new VenuesController(this.data, this.user);

            this.venuesController.Add("Venu1", "Address1", "No Description");
            this.venuesController.Add("Venu2", "Address2", "No Description");
            this.venuesController.Add("Venu2", "Address2", "No Description");

            var view = this.venuesController.All();
            var result = view.Display();
            Assert.AreEqual(ExpectedResult, result, "The result views does not match");
        }

        [TestMethod]
        [ExpectedException(typeof(AuthorizationFailedException))]
        public void TestAll_WithPresentVenuesAndInvalidPremissions_ShouldThrowException()
        {
            this.user = new User("Pesho", "asdasd", Roles.User);

            this.venuesController = new VenuesController(this.data, this.user);

            this.venuesController.Add("Venu1", "Address1", "No Description");
            this.venuesController.Add("Venu2", "Address2", "No Description");
            this.venuesController.Add("Venu2", "Address2", "No Description");
        }

        [TestMethod]
        public void TestAll_WithoutVenues_ShouldReturnErrorMessage()
        {
            const string ExpectedErrorMessage = "There are currently no venues to show.";

            this.user = new User("Pesho", "asdasd", Roles.User);

            this.venuesController = new VenuesController(this.data, this.user);

            var view = this.venuesController.All();
            var result = view.Display();

            Assert.AreEqual(ExpectedErrorMessage, result, "The view did not returned the expected error message");
        }
    }
}