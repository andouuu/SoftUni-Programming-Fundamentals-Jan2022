using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.VehicleCatalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int horseP { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks=new List<Truck>();
        }

        public void Print(List<Car> cars,List<Truck> trucks)
        {
            if (cars.Count>0)
            {
              Console.WriteLine("Cars:");
            List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.horseP}hp");
            }  
            }

            if (trucks.Count>0)
            {
               Console.WriteLine("Trucks:");
            List<Truck> sortedTrucks = trucks.OrderBy(truck => truck.Brand).ToList();
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            } 
            }
            
            //{ Brand}
            //- { Horse Power}
            //hp
            //Trucks:
            //{ Brand}: { Model}
            //- { Weight}
            //kg"

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog=new Catalog();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] vehicle=input.Split("/",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type=vehicle[0];
                string brand=vehicle[1];
                string model=vehicle[2];
                string hpOrWeight=vehicle[3];
                if (type=="Car")
                {
                    Car car=new Car();
                    car.Brand=brand;
                    car.Model=model;
                    car.horseP = int.Parse(hpOrWeight);
                    catalog.Cars.Add(car);
                }
                else if (type=="Truck")
                {
                    Truck truck=new Truck();
                    truck.Brand=brand;
                    truck.Model=model;
                    truck.Weight = int.Parse(hpOrWeight);
                    catalog.Trucks.Add(truck);
                }
            }

            catalog.Print(catalog.Cars, catalog.Trucks);
        }
    }
}
