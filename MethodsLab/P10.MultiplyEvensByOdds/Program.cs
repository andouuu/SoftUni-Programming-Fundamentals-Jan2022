using System;

namespace P10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(num)));
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {
            return GetEvenDigitsSum(num) * GetOddDiggitsSum(num);
        }
        static int GetEvenDigitsSum(int num)
        {
            int evenSum = 0;
            for (int i = num; i >0; i/=10)
            {
                int lastNum=i%10;
                if (lastNum%2==0)
                {
                    evenSum += lastNum;
                }
            }

            return evenSum;
        }
        static int GetOddDiggitsSum(int num)
        {
            int oddSum = 0;
            for (int i = num; i >0; i /= 10)
            {
                int lastNum = i % 10;
                if (lastNum % 2 != 0)
                {
                    oddSum += lastNum;
                }
            }

            return oddSum;
        }
    }
}
