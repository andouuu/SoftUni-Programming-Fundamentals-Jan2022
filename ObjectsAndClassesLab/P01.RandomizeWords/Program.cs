using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            for (int i = 0; i < words.Count; i++)
            {
                Random random = new Random();
                int rnd=random.Next(0, words.Count);
                string swappedWord=words[i];
                words[i] = words[rnd];
                words[rnd]=swappedWord;

            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
