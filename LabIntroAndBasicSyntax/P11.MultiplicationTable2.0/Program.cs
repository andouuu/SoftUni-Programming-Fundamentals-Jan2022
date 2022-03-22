using System;

namespace P10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            if (num2 > 10)
            {
                Console.WriteLine($"{num} X {num2} = {num * num2}");
            }
            else
            {
                for (int i = num2; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
        }
    }
}