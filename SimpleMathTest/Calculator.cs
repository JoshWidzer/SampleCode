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

        public List<int> GetFibonacci(int count)
        {
            var fibNumbers = new List<int>();

            var last = 1;
            var current = 1;
            int next;

            fibNumbers.Add(last);
            fibNumbers.Add(current);

            for(int index = 0; index < count-1; index++)
            {
                next = last + current;
                last = current;
                current = next;
                fibNumbers.Add(next);
            }
            return fibNumbers;
        }
    }
}
