using System;

namespace P09.CharToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            for (int i = 0; i < 3; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                str += ch;
            }

            
            Console.WriteLine(str);
        }
    }
}
