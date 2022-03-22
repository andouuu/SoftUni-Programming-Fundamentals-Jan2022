using System;
using System.Text;

namespace P05.Diggits_LetterAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string chars=string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currChar=input[i];
                if (char.IsDigit(currChar))
                {
                    digits += currChar;
                }
                else if (char.IsLetter(currChar))
                {
                    letters+=currChar;
                }
                else
                {
                    chars += currChar;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}
