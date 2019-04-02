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
        static void WorkingWithOverflow ()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max+3;
            Console.WriteLine($"This is what happens during an int overflow: {what}");
        }
        static void WorkingWithDoubles () 
        {
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);             
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }
        static void WorkingWithDecimals()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }
        static void FindingArea()
        {
            double r = 2.5;
            double area = Math.PI * r * r;
            Console.WriteLine(area);
        }
        static void Main (string[] args)
        {
            // WorkingWithIntegers();
            // WorkingWithSymbols();
            // WorkingWithOverflow();
            // WorkingWithDoubles();
            // WorkingWithDecimals();
            // FindingArea();
        }
    }
}
