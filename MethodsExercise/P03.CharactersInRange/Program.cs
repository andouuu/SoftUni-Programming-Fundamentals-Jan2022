using System;
using System.Text;

namespace P03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine(CharInRange(ch1,ch2));
        }

        static string CharInRange(char ch1, int ch2)
        {
            string charsInRange = string.Empty;
            if ((int)ch1>(ch2))
            {
                for (int i = (int)ch2+1; i < (int)ch1; i++)
                {

                    charsInRange += (char)i+" ";
                }
            }
            else
            {
                for (int i = (int)ch1+1; i < (int)ch2; i++)
                {

                charsInRange += (char) i+" ";
                } 
            }
            
            return charsInRange;
        }
    }
}
