using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace P04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            for (int i = 0; i < arr.Length/2; i++)
            {
                string oldEl = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length-1-i]=oldEl;
            }
            
            Console.WriteLine(string.Join(' ',arr));
        }
    }
}
