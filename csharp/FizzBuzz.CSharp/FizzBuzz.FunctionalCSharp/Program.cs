using System;
using System.Linq;

namespace FizzBuzz.FunctionalCSharp
{
    class Program
    {
        static string GetLine(int x) =>
            x % 3 == 0 && x % 5 == 0 ? "Fizz Buzz"
                : x % 3 == 0 ? "Fizz"
                : x % 5 == 0 ? "Buzz"
                : x.ToString();

        static void Main(string[] args)
        {
            var lines = Enumerable.Range(1, 100)
                .Select(GetLine);
            foreach (var line in lines)
                Console.WriteLine(line);
        }
    }
}