using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Orders
{
    class Product
    {
        public Product(double quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Product> products=new Dictionary<string,Product>();
            string input;
            while ((input=Console.ReadLine())!="buy")
            {
                string[] productToAdd = input.Split().ToArray();
                Product product = new Product(double.Parse(productToAdd[2]),double.Parse(productToAdd[1]));
                if (!products.ContainsKey(productToAdd[0]))
                {
                    products.Add(productToAdd[0],product);
                }
                else
                {
                    product.Quantity += products[productToAdd[0]].Quantity;
                    products[productToAdd[0]] = product;
                }
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Quantity*kvp.Value.Price:f2}");
            }
        }
    }
}
