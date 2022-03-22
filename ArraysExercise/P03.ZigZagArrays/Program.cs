using System;
using System.Linq;

namespace P03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1=new int[n];
            int[] arr2=new int[n];
            for (int i = 1; i <= arr1.Length; i++)
            {
                int[] arr3 = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (i%2!=0)
                {
                    arr1[i-1]=arr3[0];
                    arr2[i-1]=arr3[1];
                }
                else
                {
                    arr1[i - 1] = arr3[1];
                    arr2[i - 1] = arr3[0];
                }
            }

            Console.WriteLine(string.Join(' ',arr1));
            Console.WriteLine(string.Join(' ',arr2));
        }
    }
}
