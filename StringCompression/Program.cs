using System;
using System.Collections;
using System.Collections.Generic;

namespace StringCompression
{
    class Program
    {
        static void Compress(ref Hashtable compressor)
        {

        }
        static void Main(string[] args)
        {
            string strToCompress = "aaaaabbbbbgggjgkkkkkk";

            var ht = new Dictionary<char, int>();
            int val = 1;
            foreach (var s in strToCompress)
            {
                if (ht.ContainsKey(s))
                {
                    ht[s]++;
                }
                else
                {
                    ht[s] = 1;
                }
            }

            foreach (var k in ht)
            {
             Console.Write($"{k.Key}{k.Value} ");   
            }
            Console.WriteLine("Done");
        }
    }
}
