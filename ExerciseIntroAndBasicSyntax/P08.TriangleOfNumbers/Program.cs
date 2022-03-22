using System;

namespace P08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(i+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
