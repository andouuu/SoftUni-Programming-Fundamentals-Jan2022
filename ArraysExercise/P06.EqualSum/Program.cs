using System;
using System.Linq;

namespace P06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int indexSame=0;
            bool isItSameSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int right = i+1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                for (int left = i-1; left >=0; left--)
                {
                    leftSum+=numbers[left];
                }

                if (leftSum==rightSum)
                {
                    indexSame = i;
                    isItSameSum=true;
                    break;
                }

                rightSum = 0;
                leftSum = 0;
            }

            if (isItSameSum)
            {
                Console.WriteLine(indexSame);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
