using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = "";
            string[] names;
            try
            {
                
                using (StreamReader sr = new StreamReader("names.txt"))
                {
                    line = sr.ReadToEnd();

                }
                string sep = "\",\"";
                names = Regex.Split(line, sep);
                Array.Sort(names);

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }

        static int nameScore(string name)
        {

        }
    }
}
