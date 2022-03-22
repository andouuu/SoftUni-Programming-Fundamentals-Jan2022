using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine()
                .Split().Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine()
                .Split().Select(double.Parse).ToList();
            List<double> newList= new List<double>();
            int largerListCount = 0;
            if (firstList.Count>secondList.Count)
            {
                largerListCount=firstList.Count;
            }
            else
            {
                largerListCount = secondList.Count;
            }
            for (int i = 0; i < largerListCount; i++)
            {
                if (i>=firstList.Count)
                {
                    newList.Add(secondList[i]);
                }
                else if (i >= secondList.Count)
                {
                    newList.Add(firstList[i]);
                }
                else
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
