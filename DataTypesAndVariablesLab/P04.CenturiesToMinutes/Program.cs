using System;

namespace P04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal centuries = decimal.Parse(Console.ReadLine());
            decimal years = centuries * 100m;
            decimal days = Math.Floor(years * 365.2422m);
            decimal hours = days * 24m;
            decimal mins = hours * 60m;
            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {mins} minutes");
        }
    }
}
