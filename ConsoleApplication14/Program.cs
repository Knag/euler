using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int longest = 0;
            int chain = 0;
            int length;

            for (int i = 1; i < 1000000; i++)
            {
                length = chainLength(i);
                if (length > chain)
                {
                    longest = i;
                    chain = length;
                }
            }
            Console.WriteLine(longest);
            Console.Read();
        }

        static int chainLength(int start)
        {
            int length = 1;
            long value = (long)start;
            while (value != 1)
            {
                length++;
                if (value % 2 == 0)
                    value = value / 2;
                else
                    value = value * 3 + 1;
            }
            return length;
        }
    }
}
