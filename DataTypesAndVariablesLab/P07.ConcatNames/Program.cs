using System;

namespace P07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namesGlued = "";
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            namesGlued = firstName + delimiter + secondName;
            Console.WriteLine(namesGlued);
        }
    }
}
