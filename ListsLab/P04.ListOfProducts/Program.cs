using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 0; i < n; i++)
            {
                int numberOfProduct = i + 1;
                Console.WriteLine(numberOfProduct+"." + products[i]);
            }
        }
    }
}
