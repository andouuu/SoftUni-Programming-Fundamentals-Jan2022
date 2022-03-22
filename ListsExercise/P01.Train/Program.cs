using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> wagons = Console.ReadLine()
                .Split().Select(double.Parse).ToList();
            int maxPplPerWagon = int.Parse(Console.ReadLine());
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] command=input.Split();
                if (command.Contains("Add"))
                {
                    double addedWagon = double.Parse(command[1]);
                    wagons.Add(addedWagon);
                }
                else
                {
                    double addedPeople=double.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+addedPeople<=maxPplPerWagon)
                        {
                            wagons[i]+=addedPeople;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
