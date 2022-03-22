using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split().Select(double.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command.Contains("Delete"))
                {
                    numbers.Remove(double.Parse(command[1]));
                }
                else if (command.Contains("Insert"))
                {
                    numbers.Insert(int.Parse(command[2]), double.Parse(command[1]));
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
