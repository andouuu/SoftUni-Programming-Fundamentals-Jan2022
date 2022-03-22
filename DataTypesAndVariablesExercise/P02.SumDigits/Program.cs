using System;

namespace P02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n; i > 0; i/=10)
            {
                int lastNum = i % 10;
                sum+=lastNum;
            }

            Console.WriteLine(sum);
        }
    }
}
