using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Select(x=>x.ToLower())
                .ToArray();
            var countWords = new Dictionary<string, int>();
            foreach (string word in input)
            {
                if (!countWords.ContainsKey(word))
                {
                    countWords.Add(word,1);
                }
                else
                {
                    countWords[word]++;
                }
            }

            foreach (var kvp in countWords)
            {
                if (kvp.Value%2!=0)
                {
                    Console.Write(kvp.Key+" ");
                }
            }
        }
    }
}
