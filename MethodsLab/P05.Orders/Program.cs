using System;
using System.Runtime.InteropServices;

namespace P05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coffee – 1.50
            //water – 1.00
            //coke – 1.40
            //snacks – 2.00
            string order=Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Order(order,quantity);
        }

        static void Order(string order, int quantity)
        {
            switch (order)
            {
                case "coffee":
                    Console.WriteLine($"{1.50*quantity:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{1.00 * quantity:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{1.40 * quantity:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{2.00 * quantity:f2}");
                    break;
            }
        }
    }
}
