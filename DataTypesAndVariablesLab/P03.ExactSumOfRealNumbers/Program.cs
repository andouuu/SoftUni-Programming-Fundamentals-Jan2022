using System;
using System.Numerics;

namespace P03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal num=decimal.Parse(Console.ReadLine());
                sum +=num;
            }

            Console.WriteLine(sum);
        }
    }
}
