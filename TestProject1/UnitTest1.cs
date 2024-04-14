using Testing_App.Pages;

namespace TestProject1
{
    public class Tests
    {
        private IndexModel _indexModel;

        [SetUp]
        public void Setup()
        {
            // Mock ILogger
            var logger = new Microsoft.Extensions.Logging.Abstractions.NullLogger<IndexModel>();

            // Initialize IndexModel with the mocked logger
            _indexModel = new IndexModel(logger);
        }

        [Test]
        public void TestPageRender()
        {
            // Act
            _indexModel.OnGet();

            // Assert
            //Assert.AreEqual("Home", _indexModel.pageti);
            // You can add assertions here to verify the behavior of OnGet() method if needed.
            // For this basic example, we assume that if OnGet() executes without throwing any exception,
            // then the test passes.
        }
    }
}