using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box(new GlassVase("red", 3, "long", 500));
            void Negative(GlassVase v)
            {
                Console.WriteLine("I HATE IT");
            }

            box.LookAt();
            box.LookAt(Negative);


            //nu met lambda

            box.LookAt(vase =>
            {
                if (vase.Colour.Equals("red"))
                {
                    Console.WriteLine("red, as expected");
                }
                else
                {
                    Console.WriteLine("IMPOSSIBLE");
                }
            });

            if (box.Judge(v => v.Price <= 500))
            {
                Console.WriteLine("I'll Buy it");
            }
            if (box.Judge(v => v.Price > 500))
            {
                Console.WriteLine("Too expansive for me");
            }

            var shape = box.GetSomething(v => v.Form);
            Console.WriteLine("This vase is very {0}", shape);
        }
    }
}
