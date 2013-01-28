using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notFound = true;
            int smallestNr = 0;
            int currentNr = 2500;

            while(notFound)
            {
                for(int i = 20; i > 0; i--)
                {
                    if (currentNr % i != 0)
                        break;
                    if(i==1)
                    {
                        smallestNr = currentNr;
                        notFound = false;
                    }
                }
                currentNr += 20;
            }
            Console.Write(smallestNr);
            Console.ReadLine();
        }
    }
}
