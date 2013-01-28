using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum1 += i*i;
                sum2 += i;
            }

            Console.Write((sum2*sum2) - sum1);
            Console.ReadKey();
        }
    }
}
