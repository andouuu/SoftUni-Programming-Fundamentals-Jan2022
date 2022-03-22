using System;

namespace P06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastNum = 0;
            for (int i = num; i >=1; i/=10)
            {
                lastNum = i % 10;
                int m = 1;
                int factorial = 1;
                do
                {
                    factorial *= m;
                    m++;
                }
                while (m <= lastNum);

                sum += factorial;
                factorial = 1;
            }

            if (sum==num)
            {
                Console.WriteLine("yes");  
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
