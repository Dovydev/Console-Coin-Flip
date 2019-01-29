using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headsntails
{
    public class Value
    {
        public static int count;
        public static int valet;
        public static string throws;
        public static List<string> kast = new List<string>();
    }

    public class Side
    {
        public static void Gen(string name)
        {
            coinspin.spin(3, 90);
            Value.count--;

            if (Value.count < 2 && Value.count > 0)
            {
                Value.throws = " throw";
            }
            else
            {
                Value.throws = " throws";
            }

            Value.kast.Add(name);
            Console.Clear();
            Console.WriteLine(name + " - " + Value.count + Value.throws + " remaining.");
        }

        public static string GetRandom(int random)
        {
            if (random < 2500)
            {
                return "Heads";
            }
            else if (random > 2500)
            {
                return "Tails";
            }
            else
            {
                return "Corner";
            }

        }

        public static void DislpayResult()
        {
            if (Value.valet < 2)
            {
                Value.throws = " throw";
            }
            else
            {
                Value.throws = " throws";
            }
            Console.WriteLine("Your " + Value.valet + Value.throws + " was:");
            foreach (string kst in Value.kast)
            {
                Console.WriteLine(kst);
            }
        }
    }
}
