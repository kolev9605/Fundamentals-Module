namespace HotelBookingSystem.Tests
{
    using Data;
    using Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;

    [TestClass]
    public class RepositoryTests
    {
        private IRepository<User> repository;

        [TestInitialize]
        public void InitDatabase()
        {
            this.repository = new Repository<User>();
        }

        [TestMethod]
        public void TestGetById_WithValidId_ShouldReturnElement()
        {
            var firstUser = new User("Pesho", "pass11", Roles.User);
            var secondUser = new User("Gosho", "pass11", Roles.User);
            var thirsUser = new User("Kirobe", "pass11", Roles.User);

            this.repository.Add(firstUser);
            this.repository.Add(secondUser);
            this.repository.Add(thirsUser);

            var user = this.repository.Get(2);

            Assert.AreEqual(secondUser.Username, user.Username, "Returned user is not the same as the expected one");
        }

        [TestMethod]
        public void TestGetById_WithInvalidId_ShouldThrowException()
        {
            var firstUser = new User("Pesho", "pass11", Roles.User);
            var secondUser = new User("Gosho", "pass11", Roles.User);
            var thirsUser = new User("Kirobe", "pass11", Roles.User);

            this.repository.Add(firstUser);
            this.repository.Add(secondUser);
            this.repository.Add(thirsUser);

            var user = this.repository.Get(5);

            Assert.AreEqual(null, user, "The repository returned user with invalid index");
        }
    }
}
