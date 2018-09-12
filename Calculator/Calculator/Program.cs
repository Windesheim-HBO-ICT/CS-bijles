using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Deze regel defineert welke signatuur een methode nodig heeft om een berekening te zijn.
    public delegate int Berekening(int getal);

    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = DoeBerekening(10, PlusEen);
            Console.WriteLine(getal1);

            int getal2 = DoeBerekening(10, KeerTwee);
            Console.WriteLine(getal2);

            int getal3 = DoeBerekening(10, PlusEen);
            Console.WriteLine(getal3);
        }

        //Deze methode voert de berekening uit.
        //getal is waar mee wordt gerekent. 
        //berekening is een methode. De methode heeft de signatuur die overeen komt met Berekening dus de methode heeft een int nodig en geeft een int terug.
        public static int DoeBerekening(int getal, Berekening berekening)
        {
            int nieuwGetal = berekening(getal);
            return nieuwGetal;
        }

        public static int PlusEen(int getal)
        {
            return getal + 1;
        }

        public static int KeerTwee(int getal)
        {
            return getal * 2;
        }
    }
}
