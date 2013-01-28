using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 21;
            
            Int64[,] troll = new Int64[size,size];
            for (int x = 0; x < size; x ++)
            {  
               troll[x,0] = 1;
               troll[0,x] = 1;
            }
            for(int x= 1; x < size; x++)
            {
                for(int y = 1; y < size; y++)
                {
                    troll[x,y] = troll[x-1,y] + troll[x,y-1];
                }
            }
            
            Console.WriteLine(troll[size-1,size-1]);
            Console.Read();

        }
    }
}
