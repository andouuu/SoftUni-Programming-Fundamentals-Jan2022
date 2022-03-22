using System;
using System.Linq;

namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers=Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
           int sum = int.Parse(Console.ReadLine());
           int numSum = 0;
           
           for (int i = 0; i < numbers.Length; i++)
           {bool isEqual=false;
               int[] pairs = new int[2];
               for (int j = i+1; j < numbers.Length; j++)
               {
                   if (numbers[i]+numbers[j]==sum)
                   {
                       pairs[0]=numbers[i];
                       pairs[1]=numbers[j];
                       isEqual = true;
                       break;
                   }
               }

               if (isEqual)
               {
                  Console.WriteLine(string.Join(' ',pairs)); 
               }
               
           }
        }
    }
}
