using System;

namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine($"{DivideTwoFactorials(num1,num2):f2}");
        }

        static decimal Factorial(int number)
        {
            decimal factorial = 1;
            for (int i = number; i >0; i--)
            {
                factorial*=i;
            }
            return factorial;
        }

        static decimal DivideTwoFactorials(int num1, int num2)
        {
            decimal dividedFactorial = Factorial(num1) / Factorial(num2);
            return dividedFactorial;
        }
    }
}
