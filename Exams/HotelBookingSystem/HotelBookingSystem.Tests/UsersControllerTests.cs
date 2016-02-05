namespace HotelBookingSystem.Tests
{
    using System;
    using Controllers;
    using Data;
    using Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;

    [TestClass]
    public class UsersControllerTests
    {
        private IHotelBookingSystemData db;
        private User user;
        private UsersController usersController;

        [TestInitialize]
        public void InitUsersController()
        {
            this.db = new HotelBookingSystemData();
        }

        [TestMethod]
        public void TestLogout_WithLoggedUser_ShouldPass()
        {
            this.user = new User("Pesho", "parola123", Roles.User);
            this.usersController = new UsersController(this.db, this.user);

            this.usersController.Logout();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLogout_WithoutLoggedUser_ShouldThrowException()
        {
            this.user = null;
            this.usersController = new UsersController(this.db, this.user);

            this.usersController.Logout();
        }
    }
}
