using System;
using System.Data.SqlTypes;

namespace P07.VendingMashine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double nuts = 2.0;
            const double water = 0.7;
            const double crisps = 1.5;
            const double soda = 0.8;
            const double coke = 1.0;
            string money = Console.ReadLine();
            double sum = 0;
            while (money!="Start")
            {
                double coins=double.Parse(money);
                
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins!= 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sum += coins;
                }

                money = Console.ReadLine();
            }

            string typeOfProduct = Console.ReadLine();
            while (typeOfProduct!="End")
            {
                switch (typeOfProduct)
                {
                    case "Nuts":
                        if (sum-nuts>=0)
                        {
                            sum -= nuts;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum - water >= 0)
                        {
                            sum -= water;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum - crisps >= 0)
                        {
                            sum -= crisps;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum - soda >= 0)
                        {
                            sum -= soda;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum - coke >= 0)
                        {
                            sum -= coke;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                typeOfProduct = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
