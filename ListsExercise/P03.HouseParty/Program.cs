using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleGoing = new List<string>();
            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] input= Console.ReadLine().Split().ToArray();
                if (!input.Contains("not"))
                {
                    if (peopleGoing.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        peopleGoing.Add(input[0]);
                    }
                }
                else
                {
                    if (!peopleGoing.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                    else
                    {
                        peopleGoing.Remove(input[0]);
                    }
                }
                
            }

            for (int i = 0; i < peopleGoing.Count; i++)
            {
                Console.WriteLine(peopleGoing[i]);
            }
        }
    }
}
