using System;
using System.IO;
using System.Linq;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var n in (from c in File.ReadAllText(@"c:\temp\songz.txt").ToLower()
                               where Char.IsLetter(c)
                               group c by c into g
                               orderby g.Count() descending
                               select g.Key).Take(5)) Console.Write(n);

            Console.ReadKey();
        }
    }
}
