using Interfaces;
using MyGenericCalculator;

namespace CreateCalculator
{
    public class BuildCalculator : ICreateColculator
    {
        private readonly List<IOperator> _defaultOperations = new() { };

        public Calculator ManagCalculator()
        {
            
        }
        public IEnumerable<IOperator> GetOperators()
        {
            
        }
    }
    }