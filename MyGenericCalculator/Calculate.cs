using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericCalculator
{
    internal class Calculate
    {

        private readonly Func<ConsoleKey, IOperator<double>> _operation;

        public Calculate(Func<ConsoleKey, IOperator<double>> operation)
        {
            _operation = operation;
        }

        public void Test(ConsoleKey key)
        {
            IOperator<double> operation = _operation(key);
            operation.Operate(4, 5);
        }
    }
}
