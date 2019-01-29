using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headsntails
{
    class CoinFlip
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times you want to throw the coin ?");
            string input = Console.ReadLine();
            Value.valet = int.Parse(input);
            Value.count = Value.valet;

            for (int i = 1; i <= Value.valet; i++)
            {
                int random = new Random(SecureRandomizer.RandomSeed()).Next(1, 5000);

                Side.Gen(Side.GetRandom(random));

                Console.ReadLine();
                Console.Clear();
            }

            Side.DislpayResult();
            Console.ReadLine();
        }
    }
}
