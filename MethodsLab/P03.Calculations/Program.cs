using System;
using System.Xml.Serialization;

namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add":
                    AddTwoNumbers(firstNum,secondNum);
                    break;
                case "subtract":
                    SubtractTwoNumbers(firstNum, secondNum);
                    break;
                case "multiply":
                    MultiplyTwoNumbers(firstNum, secondNum);
                    break;
                case "divide":
                    DivideTwoNumbers(firstNum, secondNum);
                    break;
            }

            static void AddTwoNumbers(int a, int b)
            {
                Console.WriteLine(a+b);
            }
            static void SubtractTwoNumbers(int a, int b)
            {
                Console.WriteLine(a-b);
            }
            static void MultiplyTwoNumbers(int a, int b)
            {
                Console.WriteLine(a*b);
            }
            static void DivideTwoNumbers(int a, int b)
            {
                Console.WriteLine(a/b);
            }
        }
        
    }
}
