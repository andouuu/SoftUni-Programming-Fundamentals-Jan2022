using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,string> registeredPeople=new Dictionary<string,string>();
            for (int i = 0; i < n; i++)
            {
                string[] command=Console.ReadLine().Split(' ').ToArray();
                if (command[0]=="register")
                {
                    if (registeredPeople.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPeople[command[1]]}");
                    }
                    else
                    {
                        registeredPeople.Add(command[1],command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else
                {
                    if (registeredPeople.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} unregistered successfully");
                        registeredPeople.Remove(command[1]);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }

            }

            foreach (var kvp in registeredPeople)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
