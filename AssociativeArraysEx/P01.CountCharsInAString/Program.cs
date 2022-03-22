using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            string input = Console.ReadLine();
                
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch==' ')
                {
                    continue;
                }
                if (occurrences.ContainsKey(ch))
                {
                    occurrences[ch]++;
                }
                else
                {
                    occurrences.Add(ch,1);
                }
            }

            foreach (var kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
