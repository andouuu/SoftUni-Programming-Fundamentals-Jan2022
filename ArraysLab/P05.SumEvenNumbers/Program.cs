using System;
using System.Linq;

namespace P05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int n=nums[i];
                if (n%2==0)
                {
                    sum += n;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
