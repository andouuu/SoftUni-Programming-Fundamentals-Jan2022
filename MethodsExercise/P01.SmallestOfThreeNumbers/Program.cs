using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());
            int thirdNum=int.Parse(Console.ReadLine());
            int minNum = SmallestOfThreeNumbers(firstNum, secondNum, thirdNum);
            Console.WriteLine(minNum);
        }

        static int SmallestOfThreeNumbers(int num1, int num2, int num3)
        {
            int min = int.MaxValue;
            if (num1<min)
            {
                min=num1;
            }

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            return min;
        }
    }
}
