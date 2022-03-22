using System;
using System.Linq;

namespace P06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str="";
            for (int i = 0; i < 3; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                str += ch;
            }

            string reverseString="";
            for (int i = str.Length-1; i >=0; i--)
            {
                reverseString+=str[i]+" ";
            }
            Console.WriteLine(reverseString);

        }
    }
}
