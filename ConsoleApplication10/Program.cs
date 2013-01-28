using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool findPrime = true;
            int sumOfPrime = 5;
            int nr = 3;
            while (nr < 2000000)
            {
                nr +=2;
                if (isPrime(nr))
                {
                    sumOfPrime += nr;
                }   
            }
            Console.Write(sumOfPrime);
            Console.ReadKey();
        }
        

        static bool isPrime(long nr)
        {
            for (int i = 2; i < nr; i++)
            {
                if (nr % i == 0)
                    return false;
            }
            return true;
        }
    }
}
