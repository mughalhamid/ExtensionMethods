using Microsoft.Extensions.Configuration;
using ExtensionMethod.Library;

namespace ExtensionMethod
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsLoaded()
        {
            IConfiguration configuration = null;
            Assert.IsFalse(configuration.IsLoaded());
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}