using System;
using System.Linq;

namespace P01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string output = string.Empty;
            for (int i = input.Length-1; i >=0; i--)
            {
                output+=input[i];
            }
            Console.WriteLine($"{input} = {output}");
            }
            
        }
    }
}
