using System;
using System.Linq;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>").ToArray();
            double totalTax = 0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                
                string input=vehicles[i];
                string[] currVehicle = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string vehicleType = currVehicle[0];
                int yearsToPayTax = int.Parse(currVehicle[1]);
                int kilometersTravelled = int.Parse(currVehicle[2]);
                if (vehicleType=="family")
                {
                    double initialTax = 0;
                    if (kilometersTravelled>=3000)
                    {
                        totalTax += (kilometersTravelled / 3000) * 12 + (50 - yearsToPayTax * 5);
                         initialTax = (kilometersTravelled / 3000) * 12 + (50 - yearsToPayTax * 5);
                    }
                    else
                    {
                        totalTax += 50 - yearsToPayTax * 5;
                         initialTax = 50 - yearsToPayTax * 5;
                    }

                    Console.WriteLine($"A {vehicleType} car will pay {initialTax:f2} euros in taxes.");
                }
                else if (vehicleType=="heavyDuty")
                {
                    double initialTax = 0;
                    if (kilometersTravelled >= 9000)
                    {
                        totalTax += (kilometersTravelled / 9000) * 14 + (80 - yearsToPayTax * 8);
                        initialTax = (kilometersTravelled / 9000) * 14 + (80 - yearsToPayTax * 8);
                    }
                    else
                    {
                        totalTax += 80 - yearsToPayTax * 8;
                        initialTax = 80 - yearsToPayTax * 8;
                    }

                    Console.WriteLine($"A {vehicleType} car will pay {initialTax:f2} euros in taxes.");
                }
                else if (vehicleType=="sports")
                {
                    double initialTax = 0;
                    if (kilometersTravelled >= 2000)
                    {
                        totalTax += (kilometersTravelled / 2000) * 18 + (100 - yearsToPayTax * 9);
                        initialTax = (kilometersTravelled / 2000) * 18 + (100 - yearsToPayTax * 9);
                    }
                    else
                    {
                        totalTax += 100 - yearsToPayTax * 9;
                        initialTax = 100 - yearsToPayTax * 9;
                    }

                    Console.WriteLine($"A {vehicleType} car will pay {initialTax:f2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTax:f2} euros in taxes.");
        }
    }
}
