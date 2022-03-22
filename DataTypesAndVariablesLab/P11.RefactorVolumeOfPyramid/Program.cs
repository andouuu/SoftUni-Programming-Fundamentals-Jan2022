﻿using System;

namespace P11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double legth = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (legth * width * height) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
