using System;

namespace P05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractThirdFromSum(num1,num2,num3));
        }

        static int SumOfFirstTwo(int num1, int num2)
        {
            return num1+ num2;
        }

        static int SubtractThirdFromSum(int num1,int num2,int num3)
        {
            int sum = SumOfFirstTwo(num1, num2);
            return sum - num3;
        }
    }
}
