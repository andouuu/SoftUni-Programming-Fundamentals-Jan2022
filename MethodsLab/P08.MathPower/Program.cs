using System;

namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power=int.Parse(Console.ReadLine());
            double poweredNum = PowerOfNum(num, power);
            Console.WriteLine(poweredNum);
        }

        static double PowerOfNum(double num, int power)
        {
            double newNum =1.00;
            for (int i = 1; i <= power; i++)
            {
                newNum *= num;
            }

            return newNum;
        }
    }
}
