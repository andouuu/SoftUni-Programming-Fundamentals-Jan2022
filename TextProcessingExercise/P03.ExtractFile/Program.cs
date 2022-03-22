using System;
using System.Linq;

namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[]{'\\','.'})
                .ToArray();
            
            
            Console.WriteLine($"File name: {input[input.Length-2]}");
            Console.WriteLine($"File extension: {input[input.Length - 1]}");
        }
    }
}
