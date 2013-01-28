using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3 // 3
{
    class Program
    {
        static void Main(string[] args)
        {
            long bigEd = 600851475143;
            int primefactorsFound = 0;
            int[] factors = new int[1000000];
            int prime = 2;

            while(true)
            {
                if ((bigEd % prime) == 0)
                {
                    bigEd = bigEd/prime;
                    if (isPrime(bigEd))
                    {
                        factors[primefactorsFound] = prime;
                        break;
                    }
                    factors[primefactorsFound] = prime;
                    primefactorsFound++;
                    prime = getNextPrime(prime);
                }
                else
                {
                    prime = getNextPrime(prime); 
                }
            }
            Console.Write(bigEd);
            Console.ReadLine();
        }

        static int getNextPrime(int nr)
        {
            bool findPrime = true;
            while (findPrime)
            {
                nr++;
                if (isPrime(nr))
                    findPrime = false;
            }
            return nr;
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
