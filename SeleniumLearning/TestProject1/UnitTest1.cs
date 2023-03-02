using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method exection");

        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Setup method");

        }
        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine(" exection");

        }
    }
}