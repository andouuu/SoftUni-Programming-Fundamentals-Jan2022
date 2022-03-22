﻿using System;
using System.ComponentModel.Design;

namespace P01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SignOfNumber(num);
        }

        static void SignOfNumber(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive."); 
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
