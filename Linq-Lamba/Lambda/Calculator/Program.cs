using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEnLinq
{
    class Program
    {

        private delegate int Calculation(int int1, int int2);

        private static int CalculateDelegate(int a, int b, Calculation calculation)
        {
            return calculation(a, b);
        }

        private static int CalculateDefaultDelegate(int a, int b, Func<int, int, int> calculation)
        {
            return calculation(a, b);
        }


        static void Main(string[] args)
        {

            Console.WriteLine(CalculateDelegate(6, 4, plus));  //10
            Console.WriteLine(CalculateDelegate(6, 4, min));   //2
            Console.WriteLine(CalculateDelegate(6, 4, keer));  //24
            Console.WriteLine(CalculateDelegate(6, 4, delen)); //1

            Console.WriteLine("\n");

            Console.WriteLine(CalculateDelegate(6, 4, (x, y) => x + y));  //10
            Console.WriteLine(CalculateDelegate(6, 4, (x, y) => x - y));  //2
            Console.WriteLine(CalculateDelegate(6, 4, (x, y) => x * y));  //24
            Console.WriteLine(CalculateDelegate(6, 4, (x, y) => x / y));  //1

            Console.WriteLine("\n");

            Console.WriteLine(CalculateDefaultDelegate(6, 4, plus));  //10
            Console.WriteLine(CalculateDefaultDelegate(6, 4, min));   //2
            Console.WriteLine(CalculateDefaultDelegate(6, 4, keer));  //24
            Console.WriteLine(CalculateDefaultDelegate(6, 4, delen)); //1
                                    
            Console.WriteLine("\n");
                                    
            Console.WriteLine(CalculateDefaultDelegate(6, 4, (x, y) => x + y));  //10
            Console.WriteLine(CalculateDefaultDelegate(6, 4, (x, y) => x - y));  //2
            Console.WriteLine(CalculateDefaultDelegate(6, 4, (x, y) => x * y));  //24
            Console.WriteLine(CalculateDefaultDelegate(6, 4, (x, y) => x / y));  //1

        }

        private static int plus(int a, int b)
        {
            return a + b;
        }
        private static int keer(int a, int b)
        {
            return a * b;
        }

        private static int delen(int a, int b)
        {
            return a / b;
        }

        private static int min(int a, int b)
        {
            return a - b;
        }
    }
}
