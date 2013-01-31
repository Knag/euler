using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> abundant = new List<int>();
            int d;
            System.Numerics.BigInteger sum =0;
            for (int i = 12; i <=  28123; i++)
            {
                d = getD(i);
                if (d > i)
                    abundant.Add(i);
            }
            int count = abundant.Count();
            int[] nr = new int[28124];
            foreach (var a in abundant)
            {
                foreach (var b in abundant)
                {
                    if (b + a <= 28123)
                        nr[a + b] = 1;
                }
            }
            int last = 0;
            for (int i = 0; i <= 28123; i ++ )
            {
                if (nr[i] != 1)
                {
                    sum += i;
                    last = i;
                }
            }
            Console.WriteLine(getD(16));
            Console.WriteLine(sum);
            Console.Read();

        }

        static int getD(int inp)
        {
            int sumOfdevisors = 1;
            int sqrt = (int)Math.Sqrt(inp);
            for (int i = 2; i <= sqrt; i++)
            {
                if (inp % i == 0)
                {
                    if((inp / i) != i) 
                        sumOfdevisors += i + (inp / i);
                    else
                        sumOfdevisors += i;
                }
            }
            return sumOfdevisors;
        }
    }
}
