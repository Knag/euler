using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int answere = 0;
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a; b < 1000; b++)
                {
                    for (int c = b; c < 1000; c++)
                    {
                        if (a + c + b == 1000)
                        {
                            if((a*a + b*b) == (c*c))
                                answere = a*b*c;
                        }
                    }
                }
            }
            Console.Write(answere);
            Console.ReadKey();
        }
    }
}
