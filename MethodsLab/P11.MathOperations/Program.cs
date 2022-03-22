using System;
using System.Xml.Serialization;

namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine(AddTwoNumbers(firstNum, secondNum));
                    
                    break;
                case '-':
                    Console.WriteLine(SubtractTwoNumbers(firstNum, secondNum));
                    
                    break;
                case '*':
                    Console.WriteLine(MultiplyTwoNumbers(firstNum, secondNum));
                    
                    break;
                case '/':
                    Console.WriteLine(DivideTwoNumbers(firstNum, secondNum));
                    
                    break;
            }

            static double AddTwoNumbers(double a, double b)
            {
                return a + b;
            }
            static double SubtractTwoNumbers(double a, double b)
            {
                return a - b;
            }
            static double MultiplyTwoNumbers(double a, double b)
            {
                return a * b;
            }
            static double DivideTwoNumbers(double a, double b)
            {
                return a / b;
            }
        }

    }
}