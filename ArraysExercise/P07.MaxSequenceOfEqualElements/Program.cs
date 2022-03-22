using System;
using System.Linq;

namespace P07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int counter = 1;
            int counter2 = 0;
            
            string longestSequence = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                
                counter = 1;
                string sequence = $"{numbers[i]} ";
                for (int j = i; j < numbers.Length-1; j++)
                {
                    if (numbers[i]==numbers[j+1])
                    {
                        sequence += $"{numbers[j + 1]} ";
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter>counter2)

                {
                        longestSequence=sequence;
                        sequence = "";
                        
                        counter2 = counter;
                }
                

            }

            
                Console.WriteLine(longestSequence);
            
        }
    }
}
