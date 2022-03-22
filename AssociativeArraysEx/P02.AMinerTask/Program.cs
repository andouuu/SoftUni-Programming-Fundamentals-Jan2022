using System;
using System.Collections.Generic;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,long> ores=new Dictionary<string,long>();
            string input;
            while ((input=Console.ReadLine())!="stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (ores.ContainsKey(input))
                {
                    ores[input] += quantity;
                }
                else
                {
                    ores.Add(input,quantity);
                }
            }

            foreach (var ore in ores)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
