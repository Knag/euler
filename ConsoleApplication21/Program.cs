using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1;
            int d2;
            int sum = 0;
            for (int i = 1; i < 10000; i++)
            {
                d1 = getD(i);
                d2 = getD(d1);
                if (i == d2 && d1 != d2)
                    sum += d1;
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        static int getD(int inp)
        {
            int sumOfdevisors = 1;
            int sqrt = (int)Math.Sqrt(inp);
            for (int i = 2; i < sqrt; i++ )
            {
                if (inp % i == 0)
                {
                    sumOfdevisors += i + (inp / i);
                }
            }
            return sumOfdevisors;
        }
    }
}
