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
            TestContext.Progress.WriteLine("This is test 1");
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is test 2");
            Assert.Pass();
        }


        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("Tear down method");
        }
    }
}