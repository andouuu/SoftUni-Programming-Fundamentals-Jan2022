using System;
using System.Collections.Generic;

namespace P01.AdvertisementMessage
{
    internal class Program
    {
        class Advertisement
        {
            public List<string> Phrases=new List<string>
                { "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product." };

            public List<string> Events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            public List<string> Authors = new List<string>
                {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            public List<string> Cities = new List<string> {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            public void PrintRandom()
            {
                Random r1 = new Random();
                Random r2 = new Random();
                Random r3 = new Random();
                Random r4 = new Random();
                
                Console.WriteLine($"{this.Phrases[r1.Next(this.Phrases.Count)]}" +
                                  $" {this.Events[r2.Next(this.Events.Count)]}" +
                                  $" {this.Authors[r3.Next(this.Authors.Count)]} – {this.Cities[r4.Next(this.Cities.Count)]}.");
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Advertisement advertisement=new Advertisement();
            for (int i = 0; i < n; i++)
            {
                advertisement.PrintRandom();
            }
        }
    }
}
