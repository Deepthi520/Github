using NUnit.Framework;

namespace Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("ghjhbhv");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("gfhjmnmv");
        }
    }
}