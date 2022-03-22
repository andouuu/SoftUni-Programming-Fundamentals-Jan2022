using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            string input;
            int counter = 0;
            while ((input=Console.ReadLine())!="end")
            {
                List<string> command = input.Split().ToList();
                if (command.Contains("Add"))
                {
                    int itemToAdd = int.Parse(command[1]);
                    numbers.Add(itemToAdd);
                    counter++;
                }
                if (command.Contains("Remove"))
                {
                    int itemToRemove = int.Parse(command[1]);
                    numbers.Remove(itemToRemove);
                    counter++;
                }
                if (command.Contains("RemoveAt"))
                {
                    int indexToRemoveItem = int.Parse(command[1]);
                    numbers.RemoveAt(indexToRemoveItem);
                    counter++;
                }
                if (command.Contains("Insert"))
                {
                    int itemToInsert = int.Parse(command[1]);
                    int indexToInsert = int.Parse(command[2]);
                    numbers.Insert(indexToInsert, itemToInsert);
                    counter++;
                }
                //Contains {number} – check if the list contains the number and if so - print "Yes",
                //otherwise print "No such number".
                if (command.Contains("Contains"))
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                //PrintEven – print all the even numbers, separated by a space.
                if (command.Contains("PrintEven"))
                {
                    List<double> newListEven = new List<double>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]%2==0)
                        {
                            newListEven.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ",newListEven));
                }
                //PrintOdd – print all the odd numbers, separated by a space.
                if (command.Contains("PrintOdd"))
                {
                    List<double> newListOdd = new List<double>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            newListOdd.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", newListOdd));
                }
                //GetSum – print the sum of all the numbers.
                if (command.Contains("GetSum"))
                {
                    double sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                //Filter {condition}{ number} – print all the numbers that fulfill the given condition.
                //The condition will be either '<', '>', ">=", "<=".
                if (command.Contains("Filter"))
                {
                    List<double> filteredItems = new List<double>();
                    switch (command[1])
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i]<double.Parse(command[2]))
                                {
                                    filteredItems.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(string.Join(" ",filteredItems));
                            break;
                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > double.Parse(command[2]))
                                {
                                    filteredItems.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredItems));
                            break;
                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= double.Parse(command[2]))
                                {
                                    filteredItems.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredItems));
                            break;
                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= double.Parse(command[2]))
                                {
                                    filteredItems.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredItems));
                            break;
                    }
                }

            }

            if (counter>0)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
