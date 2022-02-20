using Interfaces;

namespace NewOperation
{
    internal class ArithmeticMean : IOperator
    {
        private dynamic _value { get; set; } 
        public ConsoleKey key { get; set; } = ConsoleKey.NumPad7;

        public T Operate<T>(T firstParam, T secondParam)
        {
            return this._value = ((dynamic)firstParam + (dynamic)secondParam)/2;
        }
    }
}
