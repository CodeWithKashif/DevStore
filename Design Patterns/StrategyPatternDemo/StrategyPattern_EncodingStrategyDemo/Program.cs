using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_EncodingStrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding encoding = new Encoding(new RSAEncodingStrategy());
            encoding.Encode("Kashif");

            encoding = new Encoding(new DESncodingStrategy());
            encoding.Encode("10000011110");

            encoding = new Encoding(new BlowFishEncodingStrategy());
            encoding.Encode("10000011110");

            Console.ReadLine();
        }
    }
}
