using System;

namespace SimpleExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Func<int, int> square = (x) => x * x;
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            var a = e.Compile();
            Console.WriteLine(e);
            Console.WriteLine(a(5));
        }
    }
}
