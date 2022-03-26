using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture=new List<string>();
            double totalPrice = 0d;

            string pattern = @"(>>)[A-Za-z]{1,}(<<)[0-9]{1,}.{0,1}[0-9]{1,}![0-9]{1,}";
            Regex regex = new Regex(pattern);
            string[] splitters = new string[] {">>", "<<", "!"};

            string cmd=Console.ReadLine();
            while (!cmd.Contains("Purchase"))
            {
                Match match= regex.Match(cmd);
                if (match.Captures.Count>0)
                {
                    string[] splittedString = match.Value.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                    furniture.Add(splittedString[0]);
                    totalPrice += double.Parse(splittedString[1]) * double.Parse(splittedString[2]);
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            foreach (var product in furniture)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
