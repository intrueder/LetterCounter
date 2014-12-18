using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.OpenText(@"c:\temp\songz.txt");
            var input = file.ReadToEnd();
            var freq = new int[26];
            for (var i = 0; i < 26; i++) freq[i] = 0;
            foreach(var x in input.ToLower())
            {
                if (x >= 'a' && x <= 'z') freq[x - 'a']++;
            }
            for (int k=0;k<5;k++)
            {
                int n = 0;
                for (int i=1;i<26;i++)
                {
                    if (freq[i] > freq[n]) n = i;
                }
                Console.Write((char)('a' + n));
                freq[n] = 0;
            }
            Console.ReadKey();
        }
    }
}
