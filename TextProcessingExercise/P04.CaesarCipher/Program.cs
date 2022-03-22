using System;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = null;
            for (var index = 0; index < input.Length; index++)
            {
                var ch = input[index];
                char newChar = (char) ((int) ch + 3);
                ch = newChar;
                output += ch;

            }

            Console.WriteLine(output);
        }
    }
}
