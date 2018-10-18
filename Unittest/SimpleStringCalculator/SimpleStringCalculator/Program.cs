using SimpleStringCalculator.Calculator;
using System;

namespace SimpleStringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World this is a very simple string calculator:");
            Console.WriteLine("Add(1,2,3)--> 1 + 2 + 3 = 6");
            Console.WriteLine("Mul(2,4,8,16)--> 2 * 4 * 8 * 16 = 1024\n");
            StringCalculator calc = new StringCalculator();
            Console.WriteLine(calc.Add("1,2,3"));
            Console.WriteLine(calc.Mul("2,4,8,16"));

            //what happens if we call calc.Add("a,1"); ???
        }
    }
}


