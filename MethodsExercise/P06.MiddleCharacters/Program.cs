using System;

namespace P06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleChars(input));
        }

        static string MiddleChars(string input)
        {
            string midChars = string.Empty;
            if (input.Length%2!=0)
            {
                midChars += input[input.Length / 2];
            }
            else
            {
                midChars+=$"{input[input.Length / 2-1]}" + $"{input[input.Length / 2]}";
            }

            return midChars;
        }
    }
}
