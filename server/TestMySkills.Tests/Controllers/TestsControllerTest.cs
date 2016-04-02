namespace TestMySkills.Tests.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestMySkills.WebAPI.Controllers;

    [TestClass]
    public class TestsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            TestsController controller = new TestsController();

            // Act
            //IEnumerable<string> result = controller.Get();

            // Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            TestsController controller = new TestsController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            TestsController controller = new TestsController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            TestsController controller = new TestsController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            TestsController controller = new TestsController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
