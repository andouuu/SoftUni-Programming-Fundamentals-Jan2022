using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            legendaryItems.Add("shards",0);
            legendaryItems["motes"] = 0;
            legendaryItems["fragments"] = 0;
            Dictionary<string, int> trashItems = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower()).ToArray();
            while (legendaryItems["shards"]<250|| legendaryItems["fragments"] < 250|| legendaryItems["motes"] <250)
            {
                
                for (int i = 0; i < input.Length; i+=2)
                {
                    if (legendaryItems.ContainsKey(input[i+1]))
                    {
                        legendaryItems[input[i+1]]+=int.Parse(input[i]);
                        if (legendaryItems["shards"] >= 250 || legendaryItems["fragments"] >= 250 || legendaryItems["motes"] >= 250)
                        {
                            break;
                        }

                    }
                    else if (trashItems.ContainsKey(input[i + 1]))
                    {
                        trashItems[input[i+1]]+= int.Parse(input[i]);
                    }
                    else
                    {
                        trashItems.Add(input[i + 1] ,int.Parse(input[i]));
                    }
                }
                if (legendaryItems["shards"] >= 250 || legendaryItems["fragments"] >= 250 || legendaryItems["motes"] >= 250)
                {
                            break;
                }
                input=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.ToLower()).ToArray();
            }

            if (legendaryItems["shards"]>=250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                legendaryItems["shards"] -= 250;
            }
            else if (legendaryItems["fragments"] >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                legendaryItems["fragments"] -= 250;
            }
            else if (legendaryItems["motes"] >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                legendaryItems["motes"] -= 250;
            }

            foreach (var kvp in legendaryItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in trashItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
