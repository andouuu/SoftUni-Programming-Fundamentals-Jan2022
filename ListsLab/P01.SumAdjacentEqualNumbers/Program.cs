using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            for (int num = 0; num < numbers.Count - 1; num++)
            {

                if (numbers[num] == numbers[num + 1])
                {
                    numbers[num] += numbers[num + 1];
                    numbers.RemoveAt(num + 1);
                    num = -1;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
