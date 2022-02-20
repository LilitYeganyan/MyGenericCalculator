
namespace Interfaces
{
    public interface IOperator
    {
        public ConsoleKey key { get; set; }
        T Operate<T>(T firstParam, T secondParam);
    }
}
