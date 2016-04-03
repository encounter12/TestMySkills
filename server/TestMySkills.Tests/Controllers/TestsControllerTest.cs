namespace TestMySkills.Tests.Controllers
{
    using System.Runtime.CompilerServices;
    using AutoMapper;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestMySkills.WebAPI.Controllers;
    using TestMySkills.Data.Repositories.Abstractions;
    using TestMySkills.WebAPI.App_Start.AutoMapperConfig;

    [TestClass]
    public class TestsControllerTest
    {
        private readonly ITestRepository testRepository;

        private readonly MapperConfiguration config;

        private readonly IMapper mapper;

        public TestsControllerTest(ITestRepository testRepository, MapperConfiguration config, IMapper mapper)
        {
            this.testRepository = testRepository;
            this.config = config;
            this.mapper = mapper;
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            TestsController controller = new TestsController(this.testRepository, this.config, this.mapper);

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
            TestsController controller = new TestsController(this.testRepository, this.config, this.mapper);

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            TestsController controller = new TestsController(this.testRepository, this.config, this.mapper);

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            TestsController controller = new TestsController(this.testRepository, this.config, this.mapper);

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            TestsController controller = new TestsController(this.testRepository, this.config, this.mapper);

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
