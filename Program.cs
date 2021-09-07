using ClassLibrary1;
using System;

namespace CalculatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 sq = new Class1();

            Console.WriteLine("Square of the entered number is {0}", sq.Square(12));
            Console.WriteLine(sq.Add(8, 63));
            Console.WriteLine(sq.Multiply(5, 8));
            Console.WriteLine(sq.Subtract(10, 42));
            Console.WriteLine(sq.Division(3, 4));
            Console.ReadLine();
        }
    }
}
