using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Dictionary<int,int> numDictionary=new Dictionary<int,int>();
            foreach (var num in input)
            {
                if (!numDictionary.ContainsKey(num))
                {
                    numDictionary.Add(num,1);
                }
                else
                {
                    numDictionary[num]++;
                }
            }

            foreach (var kvp in numDictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
