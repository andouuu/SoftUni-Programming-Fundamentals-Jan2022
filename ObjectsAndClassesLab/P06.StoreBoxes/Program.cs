using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set;}
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
        
        public decimal PriceForABox()
        {
            return Item.Price * ItemQuantity;
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes= new List<Box>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] currBox = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int serialNum = int.Parse(currBox[0]);
                string itemName=currBox[1];
                int itemQuantity = int.Parse(currBox[2]);
                decimal itemPrice=decimal.Parse(currBox[3]);
                Box box = new Box();
                box.SerialNumber= serialNum;
                box.ItemQuantity=itemQuantity;
                box.Item.Name = itemName;
                box.Item.Price= itemPrice;
                box.BoxPrice = box.PriceForABox();
                boxes.Add(box);
            }
            List<Box> sortedBoxes = new List<Box>();
            sortedBoxes = boxes.OrderByDescending(box => box.BoxPrice).ToList();
            foreach (var box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
        
    }
}
