using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            //16
            System.Numerics.BigInteger number = (System.Numerics.BigInteger)Math.Pow(2, 1000);
            Console.WriteLine(number);
            System.Numerics.BigInteger bg = 0;
            Array num = number.ToString().ToCharArray();
            foreach (var i in num)
            {
                bg += Convert.ToInt32(i.ToString());
            }
            Console.WriteLine(bg);
            Console.Read();
        }
    }
}
