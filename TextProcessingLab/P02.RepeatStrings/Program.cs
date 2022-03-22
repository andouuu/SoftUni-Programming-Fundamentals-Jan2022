using System;
using System.Linq;

namespace P02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split()
                .ToArray();
            string output=string.Empty;
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    output += word;
                }
            }

            Console.WriteLine(output);
        }
    }
}
