using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:[\b]?[ ]?){1}(?:[+][3][5][9])([- ])([2]{1})(\1)([0-9]{3})(\1)([0-9]{4})\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            string[] phoneNumbers = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ",phoneNumbers));
        }
    }
}
