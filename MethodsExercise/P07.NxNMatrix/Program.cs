using System;

namespace P07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintMatrix(input);
        }

        static void PrintLine(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(num + " ");
            }
        }

        static void PrintMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                PrintLine(num);
                Console.WriteLine();
            }
        }
    }
}
