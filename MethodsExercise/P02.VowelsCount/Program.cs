using System;
using System.Linq;

namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CountVowels(input));
        }

        static int CountVowels(string input)
        {
            int counter = 0;
            input = input.ToLower();
            char[] vowels = {'a', 'u', 'o', 'e', 'i'};
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
