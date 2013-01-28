using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Numerics.BigInteger sum = 0;

            sum = 3 * 99 * 9; // and
            sum += 3 * 3 * 9 * 10 + 100 * 3 * 3 + 3; // one two six
            sum += 3 * 4 * 9 * 10 + 100 * 3 * 4; // four five nine
            sum += 3 * 5 * 9 * 10 + 100 * 3 * 5; // three seven eight
            sum += 10 * 3; //ten
            sum += 2 * 6 * 10; //eleven twelve
            sum += 2 * 7 * 10; // fifteen sixteen
            sum += 4 * 8 * 10; // thirteen fourteen eighteen nineteen
            sum += 9 * 10; //seventeen
            sum += 3 * 5 * 10 * 10; //forty fifty sixty 
            sum += 4 * 6 * 10 * 10; // twenty thirty eighty ninety
            sum += 7 * 10 * 10; // seventy
            sum += 7 * 9 * 100; //hundred
            sum += 8; //thousand
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
