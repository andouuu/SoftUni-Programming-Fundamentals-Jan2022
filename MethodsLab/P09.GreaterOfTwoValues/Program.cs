using System;

namespace P09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "char":
                    char value1 = char.Parse(Console.ReadLine());
                    char value2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(value1, value2));
                    
                    break;
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMax(str1, str2));
                    
                    break;
            }
        }

        static char GetMax(char value1, char value2)
        {
            
            if (value1>value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        static int GetMax(int value1, int value2)
        {

            if (value1 > value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        static string GetMax(string value1, string value2)
        {
            int num=string.Compare(value1, value2,StringComparison.CurrentCulture);
            if (num>0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
    }
}
