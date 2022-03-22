using System;

namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            TopNumValidation(input);
        }

        static bool SumOfDigitsValidation(int input)
        {
            int sum = 0;
            for (int i = input; i >0; i/=10)
            {
                int lastNum = i % 10;
                sum += lastNum;
            }

            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool OddDigitValidation(int input)
        {
            int counter = 0;
            for (int i = input; i >0; i /= 10)
            {
                int lastNum = i % 10;
                if (lastNum%2!=0)
                {
                    counter++;
                }
            }

            if (counter>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TopNumValidation(int input)
        {
            for (int i = 0; i <= input; i++)
            {
                if (OddDigitValidation(i)==true && SumOfDigitsValidation(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
        //•	Holds at least one odd digit, e.g. 232, 707, 87578
        //•	Some examples of top numbers are: 17, 161, 251, 4310, 123200 

    }
}
