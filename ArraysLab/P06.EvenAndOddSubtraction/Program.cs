using System;
using System.Linq;

namespace P06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];
                if (number%2==0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum+=number;
                }
            }

            Console.WriteLine(evenSum-oddSum);
        }
    }
}
