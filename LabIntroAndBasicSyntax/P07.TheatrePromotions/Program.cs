﻿using System;

namespace P07.TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            switch (typeOfDay)
            {
                case "weekday":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age > 18 && age <= 64) 
                    {
                        Console.WriteLine("18$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "weekend":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
            }
        }
    }
}
