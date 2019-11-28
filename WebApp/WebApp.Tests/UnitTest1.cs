using NUnit.Framework;

namespace WebApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(true);
        }

        [Test]
        public void TestMethod2()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(true);
        }

        [Test]
        public void TestMethod3()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(true);
        }

        [Test]
        public void TestMethod4()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(true);
        }
    }
}