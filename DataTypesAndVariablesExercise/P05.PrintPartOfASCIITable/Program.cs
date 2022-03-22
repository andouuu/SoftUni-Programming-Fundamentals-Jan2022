using System;

namespace P05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <=end; i++)
            {
                Console.Write(Char.ConvertFromUtf32(i)+" ");
            }
        }
    }
}
