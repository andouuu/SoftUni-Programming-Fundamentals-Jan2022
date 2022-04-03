using System;
using System.Text.RegularExpressions;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(.*?)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$";
            Regex regex=new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string currInput=Console.ReadLine();
                string currPassword = "";
                if (regex.IsMatch(currInput))
                {
                    Match match=regex.Match(currInput);
                    currPassword+=match.Groups[2].Value+ match.Groups[3].Value+ match.Groups[4].Value+ match.Groups[5].Value;
                    Console.WriteLine("Password: "+currPassword);
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
