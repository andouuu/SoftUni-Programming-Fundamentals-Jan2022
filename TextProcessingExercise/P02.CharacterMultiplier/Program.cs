using System;
using System.Linq;

namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            int sum = 0;
            string firstWord = input[0];
            string secondWord = input[1];
            int biggerWordLength = Math.Max(firstWord.Length, secondWord.Length);
            for (int i = 0; i < biggerWordLength; i++)
            {
                
                if (firstWord.Length<secondWord.Length&&i>firstWord.Length-1)
                {
                        sum += (int) secondWord[i];
                }
                else if (firstWord.Length>secondWord.Length&&i>secondWord.Length-1)
                {
                        sum += (int) firstWord[i];
                }
                else
                {
                    sum += (int) firstWord[i] * (int) secondWord[i];
                }
                    
            }
            
            Console.WriteLine(sum);
        }
    }
}
