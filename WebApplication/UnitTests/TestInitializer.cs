using ApplicationLayer.Services;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TestInitializer
    {
        [OneTimeSetUp]
        public void Init()
        {
            
        }

        [OneTimeTearDown]
        public void Dispose()
        { /* ... */ }
    }
}
