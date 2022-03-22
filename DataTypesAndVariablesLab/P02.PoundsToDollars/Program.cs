using System;

namespace P02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal exchangeRate = 1.31m;
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * exchangeRate;
            Console.WriteLine($"{Math.Round(dollars,3,MidpointRounding.AwayFromZero):f3}");
        }
    }
}
