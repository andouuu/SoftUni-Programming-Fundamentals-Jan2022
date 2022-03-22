using System;

namespace P10.LowerToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            if (char.IsLower(ch))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
