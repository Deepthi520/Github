using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    internal class Assert
    {
        internal static void Pass()
        {
            throw new NotImplementedException();
        }
    }

    internal class TestAttribute : Attribute
    {
    }

    internal class SetUpAttribute : Attribute
    {
    }
}