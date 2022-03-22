using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split().Select(double.Parse).ToList();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] command=input.Split();
                //Add {number} – add the given number to the end of the list
                if (command.Contains("Add"))
                {
                    numbers.Add(double.Parse(command[1]));
                }
                //Insert {number} {index} – insert the number at the given index
                if (command.Contains("Insert"))
                {
                    if (double.Parse(command[2])>numbers.Count-1|| double.Parse(command[2])<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(command[2]),double.Parse(command[1]));
                    }
                }
                //Remove { index} – remove the number at the given index
                if (command.Contains("Remove"))
                {
                    if (double.Parse(command[1]) > numbers.Count - 1 || double.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                }
                //Shift left { count} – first number becomes last. This has to be repeated the specified number of times
                if (command.Contains("left"))
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        double firstNumber = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNumber);
                    }
                }
                //Shift right { count} – last number becomes first. To be repeated the specified number of times
                if (command.Contains("right"))
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        double lastNumber = numbers[numbers.Count-1];
                        numbers.RemoveAt(numbers.Count-1);
                        numbers.Insert(0,lastNumber);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
