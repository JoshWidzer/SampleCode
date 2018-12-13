using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathTest
{
    class Calculator
    {
        private IAdder adder;

        public Calculator(IAdder adder)
        {
            this.adder = adder;
        }

        public int AddTwoNumbers(int first, int second)
        {
            return adder.Add(first, second);
        }
    }
}
