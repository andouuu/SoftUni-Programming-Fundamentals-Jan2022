using System;
using System.Linq;

namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfRotations; i++)
            {
                int firstNum = arr[0];
                for (int rot = 0; rot < arr.Length-1; rot++)
                {
                    arr[rot] = arr[rot + 1];
                }

                arr[arr.Length-1]=firstNum;
            }

            Console.WriteLine(string.Join(' ',arr));
        }
    }
}
