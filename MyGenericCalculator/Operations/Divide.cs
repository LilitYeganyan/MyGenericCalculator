using Interfaces;
using System;

namespace MyGenericCalculator
{
    public class Divide : IOperator
    {
        public dynamic value { get; set; }
        public ConsoleKey key { get; set; } = ConsoleKey.Divide;

        public T Operate<T>(T firstParam, T secondParam)
        {
            return this.value = (dynamic)firstParam / (dynamic)secondParam;
        }
    }
}
