using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleMathTest
{
    [TestClass]
    public class SimpleMathTest
    {
        [TestMethod]
        public void OneAndOneIsTwo()
        {
            var math = new SimpleMath();
            var result = math.Add(1, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TwoAndTwoIsNotThree()
        {
            var math = new SimpleMath();
            var result = math.Add(2, 2);
            Assert.AreNotEqual(3, result);
        }
    }
}
