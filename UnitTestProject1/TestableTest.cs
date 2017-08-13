using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class TestableTest
    {
        [TestMethod]
        public void testCount()
        {
            Testable t = new Testable();
            Assert.AreEqual(1, t.getCount());
        }
    }
}
