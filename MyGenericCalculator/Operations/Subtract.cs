using System;
using Interfaces;
namespace MyGenericCalculator
{
    public class Subtract : IOperator
    {
        public dynamic value { get; set; }
        public ConsoleKey key { get; set; } = ConsoleKey.Subtract;
        public T Operate<T>(T firstParam, T secondParam)
        {
            return this.value = (dynamic)firstParam - (dynamic)secondParam;
        }
    }
}
