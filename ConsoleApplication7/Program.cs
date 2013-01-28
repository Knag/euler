using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool findPrime = true;
            int nrOfPrime = 0;
            int nr = 1;
            while (findPrime)
            {
                nr++;
                if (isPrime(nr))
                {
                    nrOfPrime++;
                    if(nrOfPrime == 10001)
                        findPrime = false;
                }   
            }
            Console.Write(nr);
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
