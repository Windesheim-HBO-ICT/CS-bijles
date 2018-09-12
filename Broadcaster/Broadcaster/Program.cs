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
        private StuurBericht _verstuurders;

        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            VoegToeVerstuurder(VerstuurBerichtViaEmail);
            VoegToeVerstuurder(VerstuurBerichtSchreeuwen);
        }

        public void VerstuurBericht(String bericht)
        {
            _verstuurders(bericht);
        }

        public void VoegToeVerstuurder(StuurBericht verstuurder)
        {
            _verstuurders += verstuurder;
        }

        public void VerstuurBerichtViaEmail(String bericht)
        {
            Console.WriteLine("Nieuwe email: "+bericht);
        }
        
        public void VerstuurBerichtSchreeuwen(String bericht)
        {
            Console.WriteLine(bericht.ToUpper());
        }
    }
}
