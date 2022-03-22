using System;

namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                if (IsNumPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool IsNumPalindrome(string input)
        {
            int normalNum=int.Parse(input);
            string newNum=string.Empty;
            bool isNumPalindrome = true;
            for (int i = normalNum; i >0; i/=10)
            {
                newNum += i % 10;
            }

            int backwardsNum = int.Parse(newNum);
            if (backwardsNum!=normalNum)
            {
                isNumPalindrome = false;
            }

            return isNumPalindrome;
        }
    }
}
