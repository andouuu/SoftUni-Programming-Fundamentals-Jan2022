using System;
using System.Linq;

namespace P04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string input = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                while (input.Contains(bannedWords[i]))
                {
                    
                    string numOfStars = string.Empty;
                    for (int j = 0; j < bannedWords[i].Length; j++)
                    {
                        numOfStars += "*";
                    }
                    string replacedBanWord = input.Replace(bannedWords[i], numOfStars);
                    input = replacedBanWord;

                }

            }

            Console.WriteLine(input);
        }
    }
}
