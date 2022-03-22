using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            
            for (int i = 0; i < Math.Max(firstHand.Count,secondHand.Count); i++)
            {
                if (firstHand.Count==0||secondHand.Count==0)
                {
                    break;
                }
                int firstCard=firstHand[i];
                int secondCard=secondHand[i];
               
                if (firstCard>secondCard)
                {
                    firstHand.Remove(firstCard);
                    secondHand.Remove(secondCard);
                    firstHand.Add(firstCard);
                    firstHand.Add(secondCard);
                }
                else if (secondCard>firstCard)
                {
                    firstHand.Remove(firstCard);
                    secondHand.Remove(secondCard);
                    secondHand.Add(secondCard);
                    secondHand.Add(firstCard);
                }
                else
                {
                    firstHand.Remove(firstCard);
                    secondHand.Remove(secondCard);
                }

                i = -1;
            }

            int sum = 0;
            if (firstHand.Count==0)
            {
                for (int i = 0; i < secondHand.Count; i++)
                {
                    sum += secondHand[i];
                }

                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else if (secondHand.Count==0)
            {
                for (int i = 0; i < firstHand.Count; i++)
                {
                    sum+=firstHand[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
