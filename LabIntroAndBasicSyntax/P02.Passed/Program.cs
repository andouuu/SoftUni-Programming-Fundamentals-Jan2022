﻿using System;

namespace P02.Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
