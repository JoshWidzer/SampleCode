﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathTest
{
    class SimpleMath : IAdder
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
