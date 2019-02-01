using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcCases.Utils;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pd4Discount pd4Discount = new Pd4Discount(1, 1);
            pd4Discount.Discount(5, 30);
            Assert.AreEqual(pd4Discount.FreeCount, 5);
        }
    }
}
