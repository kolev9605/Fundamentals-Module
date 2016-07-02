namespace BULS.Tests
{
    using System.Linq;
    using BangaloreUniversityLearningSystem;
    using BangaloreUniversityLearningSystem.Controllers;
    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CoursesControllerTests
    {
        private IBangaloreUniversityData mockedData;

        [TestMethod]
        public void TestAddLecture()
        {
            var course = new Course("kur kurs");

            var repoMock = new Mock<IRepository<Course>>();
            repoMock.Setup(x => x.Get(It.IsAny<int>())).Returns(course);

            var dataMock = new Mock<IBangaloreUniversityData>();
            dataMock.Setup(x => x.CoursesRepository).Returns(repoMock.Object);

            var lectureName = "kur lekciq";

            this.mockedData = dataMock.Object;

            var controller = new CoursesController(
                this.mockedData, 
                new User("nasko", "123445667432", Role.Lecturer));

            var view = controller.AddLecture(1, "kur lekciq");

            Assert.AreEqual(course.Lectures.First().Name, lectureName, "The lecture name is not equal to the expected one");
        }
    }
}
