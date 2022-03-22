using System;

namespace P09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            int sum = 0;
            int days = 0;
            for (int i = (int)startingYield; i >=100; i-=10)
            {
                int yieldPerDay = (int)i - 26;
                sum+=yieldPerDay;
                days++;
            }

            if (sum>=26)
            {
                sum-=26;
            }

            Console.WriteLine(days);

            Console.WriteLine(sum);
        }
    }
}
