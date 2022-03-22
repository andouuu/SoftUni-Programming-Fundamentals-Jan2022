using System;
using System.Reflection.Metadata.Ecma335;

namespace P02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divider = 0;
            if (num % 10 == 0)
            {
                divider = 10;
            }
            else if (num%7==0)
            {
                divider = 7;
            }
            else if (num%6==0)
            {
                divider = 6;
            }
            else if (num%3==0)
            {
                divider = 3;
            }
            else if (num%2==0)
            {
                divider=2;
            }
            else
            {
                Console.WriteLine("Not divisible");
                
            }

            if (num % 10 == 0|| num % 7 == 0 || num % 6 == 0 || num % 3 == 0 || num % 2 == 0)
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
        }
    }
}
