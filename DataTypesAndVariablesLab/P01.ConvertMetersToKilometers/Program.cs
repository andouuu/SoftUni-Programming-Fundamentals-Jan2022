using System;

namespace P01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            double km = (double) m / 1000.0;
            Console.WriteLine($"{Math.Round(km,2,MidpointRounding.AwayFromZero):f2}");
        }
    }
}
