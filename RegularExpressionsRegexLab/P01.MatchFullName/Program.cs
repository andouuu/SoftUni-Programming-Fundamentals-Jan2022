using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
