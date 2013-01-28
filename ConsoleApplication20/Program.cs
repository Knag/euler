using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Numerics.BigInteger factorial = 1;

            for (int i = 1; i < 101; i++)
                factorial = factorial * i;

            string fac = factorial.ToString();
            var chararray = fac.ToCharArray();
            int sum = 0;
            foreach (var c in chararray)
                sum += Convert.ToInt32(c.ToString());

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
