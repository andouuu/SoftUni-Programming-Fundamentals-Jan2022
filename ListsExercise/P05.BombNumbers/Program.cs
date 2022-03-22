using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            int[] input = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int bomb = input[0];
            int power = input[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int bombRight = power;
                    int bombLeft = power;
                    while (i+bombRight>numbers.Count-1)
                    {
                        bombRight--;
                    }

                    while (i-bombLeft<0)
                    {
                        bombLeft--;
                    }

                    if (i<numbers.Count-1)
                    {
                        numbers.RemoveRange(i+1,bombRight);
                    }
                    if (i > 0)
                    {
                        numbers.RemoveRange(i-bombLeft,bombLeft+1);
                    }
                    
                }
            }

            numbers.Remove(bomb);
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}