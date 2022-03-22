using System;
using System.Collections.Generic;

namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                
                if (synonyms.ContainsKey(word))
                {
                        synonyms[word].Add(synonym);
                }
                else
                {
                        synonyms.Add(word,new List<string>(){synonym});
                }
                
                
            }

            foreach (var kvp in synonyms)
            {
                
                Console.WriteLine($"{kvp.Key} - " + string.Join(", ",kvp.Value));
            }
        }
    }
}
