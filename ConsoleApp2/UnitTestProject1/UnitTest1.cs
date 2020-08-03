using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp2.Program p = new ConsoleApp2.Program();
            Assert.AreEqual(p.sum(2,5),7);
        }
    }
}
