using System;

namespace P12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int topNumber = int.Parse(Console.ReadLine());
            
            
            bool isSpecialNumber = false;
            for (int number = 1; number <= topNumber; number++)
            {
                int sum = 0;
                int numToTest = number;
                while (numToTest > 0)
                {
                    sum += numToTest % 10;
                    numToTest /= 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}",number, isSpecialNumber);
                
                
            }

        }
    }
}
