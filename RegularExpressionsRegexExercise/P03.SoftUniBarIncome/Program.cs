using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    class Customer
    {
        public Customer(string name, string product, double price)
        {
            CustomerName = name;
            Product = product;
            TotalPrice=price;
        }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public double TotalPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers=new List<Customer>();
            string pattern =
                @"%([A-Z]{1}[a-z]+)%[^\|$%\.]*<(\w+)>[^\|$%\.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);
            string cmd;
            double totalPrice = 0;
            while ((cmd=Console.ReadLine())!="end of shift")
            {
                if (regex.IsMatch(cmd))
                {
                    customers.Add(new Customer(regex.Match(cmd).Groups[1].Value
                        , regex.Match(cmd).Groups[2].Value
                        , int.Parse(regex.Match(cmd).Groups[3].Value) 
                          * double.Parse(regex.Match(cmd).Groups[4].Value)));
                    totalPrice += int.Parse(regex.Match(cmd).Groups[3].Value)
                                  * double.Parse(regex.Match(cmd).Groups[4].Value);
                }
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerName}: {customer.Product} - {customer.TotalPrice:f2}");
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
