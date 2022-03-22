using System;
using System.Text;

namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numOfRepeats = int.Parse(Console.ReadLine());
            string newString = RepeatedString(input, numOfRepeats);
            Console.WriteLine(newString);
        }

        static string RepeatedString(string input, int numOfRepeats)
        {
            StringBuilder newString= new StringBuilder();
            for (int i = 0; i < numOfRepeats; i++)
            {
                newString.Append(input);
            }
            return newString.ToString();
        }
    }
}
