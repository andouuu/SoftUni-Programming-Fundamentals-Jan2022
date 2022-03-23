using System;
using System.Linq;

namespace P08.LettersChangeNumbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0;
            foreach (var str in inputStrings)
            {
                sum += FindSumOfCurrString(str);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static double FindSumOfCurrString(string str)
        {
            double sum=0;
            string removedLetters = str.Substring(1,str.Length-2);
            char firstLetter = str[0];
            char lastLetter = str[str.Length-1];
            double num = double.Parse(removedLetters);
            if (char.IsUpper(firstLetter))
            {
                sum += num/PositionInAlphabet(firstLetter);
            }
            else
            {
                sum += num * PositionInAlphabet(firstLetter);
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= PositionInAlphabet(lastLetter);
            }
            else
            {
                sum += PositionInAlphabet(lastLetter);
            }
            return sum;
        }

        static int PositionInAlphabet(char ch)
        {
            if (char.IsUpper(ch))
            {
                return (int) ch - 64;
            }
            else
            {
                return (int) ch - 96;
            }
           
        }
    }
}
