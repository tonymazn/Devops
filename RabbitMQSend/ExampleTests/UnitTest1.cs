using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleTests
{
    /// <summary>
    /// Build Test 1 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1 + 2, 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1 + 3, 4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1 + 3, 4);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1 + 3, 4);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1 + 4, 5);
        }
    }
}
