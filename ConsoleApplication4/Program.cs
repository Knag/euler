using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int biggest = 0;
            for(int i = 999; i > 99; i--)
            {
                for (int x = 999; x > 99; x--)
                {
                    temp = i*x;
                    if(temp < biggest)
                        break;
                    if (isPalindrome(temp))
                        biggest = temp;
                }
            }
            Console.Write(biggest);
            Console.ReadLine();
        }

        static bool isPalindrome(int pal)
        {
            char[] palin = pal.ToString().ToCharArray();
            Array.Reverse(palin);
            var palinIn = new string(palin);
            return palinIn.Equals(pal.ToString());
        }
    }
}
