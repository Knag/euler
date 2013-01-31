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
            List<string> alphabet = new List<string>();
            System.Numerics.BigInteger biggest = 0;
            int c = 1;

            alphabet.Add("a");
            alphabet.Add("b");
            alphabet.Add("c");
            alphabet.Add("d");
            alphabet.Add("e"); // 5
            alphabet.Add("f");
            alphabet.Add("g");
            alphabet.Add("h");
            alphabet.Add("i");
            alphabet.Add("j"); //10
            alphabet.Add("k");
            alphabet.Add("l");
            alphabet.Add("m");
            alphabet.Add("n");
            alphabet.Add("o");
            alphabet.Add("p");
            alphabet.Add("q");
            alphabet.Add("r");
            alphabet.Add("s");
            alphabet.Add("t"); // 20
            alphabet.Add("u");
            alphabet.Add("v");
            alphabet.Add("w");
            alphabet.Add("x");
            alphabet.Add("y"); //25
            alphabet.Add("z");

            try
            {
                
                using (StreamReader sr = new StreamReader("names.txt"))
                {
                    line = sr.ReadToEnd();

                }
                string sep = "\",\"";
                names = Regex.Split(line.ToLower(), sep);
                Array.Sort(names);
                foreach (var name in names)
                {
                    biggest += c * nameScore(name, alphabet);
                    c++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

 
            
            nameScore("colin", alphabet);
            Console.WriteLine(biggest);
            Console.Read();
        }



        static int nameScore(string name, List<string> alphabet)
        {
            int score = 0;
            foreach(var c in name.ToCharArray())
            {
                score += alphabet.IndexOf(c.ToString())+1;
            }
            return score;
        }
    }
}
