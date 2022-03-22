﻿using System;
using System.Net.Sockets;


namespace P01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int n = int.Parse(Console.ReadLine());
            if (n<1||n>7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
              Console.WriteLine(days[n-1]);  
            }
            
        }
    }
    
}
