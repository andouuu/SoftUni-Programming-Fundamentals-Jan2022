using System;

namespace P07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfLitters=0;
            for (int i = 0; i < n; i++)
            {
                int littersToAdd = int.Parse(Console.ReadLine());
                if (littersToAdd+sumOfLitters>255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    sumOfLitters += littersToAdd;
                }
            }

            Console.WriteLine(sumOfLitters);
        }
    }
}
