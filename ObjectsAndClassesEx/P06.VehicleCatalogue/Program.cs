using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.VehicleCatalogue
{
    class Car
    {
        public Car(string model, string color, double horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public override string ToString()
        {
            string result = "";

            result += $"Type: {this.GetType().Name}";
            result += Environment.NewLine + $"Model: {this.Model}";
            result += Environment.NewLine + $"Color: {this.Color}";
            result += Environment.NewLine + $"Horsepower: {this.HorsePower}";

            return result;
        }
    }

    class Truck
    {
        public Truck(string model, string color, double horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public override string ToString()
        {
            string result = "";

            result += $"Type: {this.GetType().Name}";
            result += Environment.NewLine + $"Model: {this.Model}";
            result += Environment.NewLine + $"Color: {this.Color}";
            result += Environment.NewLine + $"Horsepower: {this.HorsePower}";

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string command = Console.ReadLine();
            while (!command.Contains("End"))
            {
                var data = command.Split(" ");
                var type = data[0];
                var model = data[1];
                var color = data[2];
                var horsepower = int.Parse(data[3]);

                if (type == "truck")
                {
                    Truck truck = new Truck(model, color, horsepower);
                    trucks.Add(truck);
                }
                else if (type == "car")
                {
                    Car car = new Car(model, color, horsepower);
                    cars.Add(car);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (!command.Contains("Close the Catalogue"))
            {
                Car car = null;
                Truck truck = trucks.FirstOrDefault(x => x.Model == command);
                if (truck == null)
                {
                    car = cars.FirstOrDefault(x => x.Model == command);
                    Console.WriteLine(car);
                }
                else
                {
                    Console.WriteLine(truck);
                }

                command = Console.ReadLine();
            }

            double averageCars = cars.Count > 0 ? (cars.Sum(x => x.HorsePower) / cars.Count) : 0;
            double averageTrucks = trucks.Count > 0 ? (trucks.Sum(x => x.HorsePower) / trucks.Count) : 0;
            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
        }
    }
}
