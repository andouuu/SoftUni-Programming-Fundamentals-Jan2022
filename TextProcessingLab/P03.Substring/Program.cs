using System;
using System.Linq;

namespace P03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            while (secondString.Contains(firstString))
            {
                int i=secondString.IndexOf(firstString);
                string thirdString = secondString.Remove(i, firstString.Length);
                secondString = thirdString;
            }

            Console.WriteLine(secondString);
        }
    }
}
