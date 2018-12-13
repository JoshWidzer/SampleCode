using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace SimpleMathTest
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
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

        [TestMethod]
        public void First10Fibonacci()
        {
            var math = new SimpleMath();
            var calculator = new Calculator(math);
            var result = calculator.GetFibonacci(10);
            Approvals.VerifyAll(result, "Index: ");
        }
    }
}
