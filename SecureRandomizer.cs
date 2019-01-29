using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace headsntails
{
    public static class SecureRandomizer
    {
        public static int RandomSeed()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4];//4 for int32
                rng.GetBytes(randomNumber);
                return BitConverter.ToInt32(randomNumber, 0);
            }
        }
    }
}
