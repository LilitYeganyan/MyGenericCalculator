﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericCalculator
{
    internal class Subtract
    {
        public double value { get; set; }
        public double Operate(double firstParam, double secondParam)
        {
            return value = firstParam - secondParam;
        }
    }
}