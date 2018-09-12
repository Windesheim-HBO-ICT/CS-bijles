using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadcaster
{
    public delegate void StuurBericht(String bericht);

    public class Program
    {   
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            messenger.VoegToeVerstuurder(VerstuurBerichtViaEmail);
            messenger.VoegToeVerstuurder(VerstuurBerichtSchreeuwen);
            messenger.VerstuurBericht("Wij maken huiswerk");
        }

        public static void VerstuurBerichtViaEmail(String bericht)
        {
            Console.WriteLine("Nieuwe email: "+bericht);
        }
        
        public static void VerstuurBerichtSchreeuwen(String bericht)
        {
            Console.WriteLine(bericht.ToUpper());
        }
    }

    public class Messenger
    {
        private event StuurBericht Verstuurders;

        public void VerstuurBericht(String bericht)
        {
            if (Verstuurders != null)
            {
                Verstuurders(bericht);
            }
        }

        public void VoegToeVerstuurder(StuurBericht verstuurder)
        {
            Verstuurders += verstuurder;
        }
    }
}
