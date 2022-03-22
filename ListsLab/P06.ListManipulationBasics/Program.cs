using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split().Select(double.Parse).ToList();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                List<string> command = input.Split().ToList();
                if (command.Contains("Add"))
                {
                    int itemToAdd = int.Parse(command[1]);
                    numbers.Add(itemToAdd);
                }
                if (command.Contains("Remove"))
                {
                    int itemToRemove = int.Parse(command[1]);
                    numbers.Remove(itemToRemove);
                }
                if (command.Contains("RemoveAt"))
                {
                    int indexToRemoveItem=int.Parse(command[1]);
                    numbers.RemoveAt(indexToRemoveItem);
                }
                if (command.Contains("Insert"))
                {
                    int itemToInsert=int.Parse(command[1]);
                    int indexToInsert=int.Parse(command[2]);
                    numbers.Insert(indexToInsert, itemToInsert);
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
