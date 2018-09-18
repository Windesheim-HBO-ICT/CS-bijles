using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadcaster
{
    public class BerichtEventArgs
    {
        public BerichtEventArgs(string inhoud)
        {
            Inhoud = inhoud;
        }

        public string Inhoud { get; }
    }

    public delegate void StuurBericht(BerichtEventArgs bericht);


    public class Program
    {   
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            messenger.VoegToeVerstuurder(VerstuurBerichtViaEmail);
            messenger.VoegToeVerstuurder(VerstuurBerichtSchreeuwen);
            messenger.VerstuurBericht("Wij maken huiswerk");
        }

        public static void VerstuurBerichtViaEmail(BerichtEventArgs bericht)
        {
            Console.WriteLine("Nieuwe email: "+bericht.Inhoud);
        }
        
        public static void VerstuurBerichtSchreeuwen(BerichtEventArgs bericht)
        {
            Console.WriteLine(bericht.Inhoud.ToUpper());
        }
    }

    public class Messenger
    {
        private event StuurBericht Verstuurders;

        public void VerstuurBericht(String inhoud)
        {
            BerichtEventArgs bericht = new BerichtEventArgs(inhoud);
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
