using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            int originalLength=numbers.Count/2;
            for (int i = 0; i < originalLength; i++)
            {
                numbers[i] += numbers[numbers.Count -1];
                
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
