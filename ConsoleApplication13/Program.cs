using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            System.Numerics.BigInteger bgtemp = 0;
            System.Numerics.BigInteger bg = 0;
            for (int i = 0; i < 100; i++)
            {
                 s = Console.ReadLine();
                 System.Numerics.BigInteger.TryParse(s, out bgtemp);
                 bg += bgtemp;
            }
            Console.WriteLine("result:");
            Console.WriteLine(bg);
        }
    }
}
