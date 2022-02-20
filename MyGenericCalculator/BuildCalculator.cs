using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MyGenericCalculator
{
    internal class BuildCalculator : ICreateColculator
    {
        private readonly List<IOperator> _defaultOperations = new() { new Divide(), new Sum(), new Multiply(), new Subtract() };

        public Calculator CreatCalculator()
        {
            var operation = GetOperators();
            _defaultOperations.AddRange(operation);
            Calculator calculator = new Calculator(_defaultOperations);
            return calculator;
        }
        public IEnumerable<IOperator> GetOperators()
        {
            List<IOperator> operations = new List<IOperator>();
            List<Assembly> assemblys = new List<Assembly>();
            string path = "C:\\CProjectPath";

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                assemblys.Add(Assembly.LoadFile(dll));
            }

            foreach (var ass in assemblys)
            {
                var taypes = ass.GetTypes();
                var operationType = from t in taypes where t.IsClass && typeof(IOperator).IsAssignableFrom(t) select t;
                foreach (var item in operationType)
                {
                    var instance = Activator.CreateInstance(item);
                    operations.Add((IOperator)instance);
                }
            }
            return operations;
        }
    }
}
