using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 4;
            int b = 2;
            int c = a + b;
            int d = 19;
            int e = 21;
            Console.WriteLine(a/b+c*d-e);
            Console.WriteLine(a / b + c);
            Console.WriteLine(d - e);
        }
        static void WorkingWithSymbols()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
        }
        static void Main (string[] args)
        {
            WorkingWithIntegers();
            WorkingWithSymbols();
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }
    }
}
