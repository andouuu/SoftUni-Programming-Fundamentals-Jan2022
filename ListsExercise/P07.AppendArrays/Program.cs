using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> input =Console.ReadLine()
                .Split('|')
                .ToList();
            List<int> output = new List<int>();
            for (int i = input.Count-1; i >=0; i--)
            {
                int[] arrToAdd = input[i].Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < arrToAdd.Length; j++)
                {
                    output.Add(arrToAdd[j]);
                }
            }

            Console.WriteLine(string.Join(" ",output));
        }
    }
}
