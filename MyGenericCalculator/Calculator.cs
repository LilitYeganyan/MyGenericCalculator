using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGenericCalculator
{
    public class Calculator
    {
        public IEnumerable<IOperator> operations;

        public Calculator(IEnumerable<IOperator> operations)
        {
            this.operations = operations;
        }

        public IOperator GetOperation(ConsoleKey key)
        {
            var opetaion = this.operations.Where(o => o.key == key);
            return operations.First();
        }
        public IOperator Calculate<T>(ConsoleKey key, T firstParam, T secondParam)
        {
            return (IOperator)GetOperation(key).Operate(firstParam, secondParam);
        }
    }
}
