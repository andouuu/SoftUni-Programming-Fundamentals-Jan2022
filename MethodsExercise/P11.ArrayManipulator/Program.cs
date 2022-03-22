using System;
using System.Linq;

namespace P11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command;
            
            while ((command=Console.ReadLine())!="end")
            {
                if (command.Contains("exchange"))
                {
                    string[] exchange = command.Split().ToArray();
                    string input=exchange[1];
                    int[] newArray = IndexExchangeArray(arr,input).Split().Select(int.Parse).ToArray();
                    arr = newArray;
                }
                else if (command.Contains("max"))
                {
                    if (command.Contains("odd"))
                    {
                        IndexOfMaxOdd(arr);
                    }
                    else if (command.Contains("even"))
                    {
                        IndexOfMaxEven(arr);
                    }
                }
                else if (command.Contains("min"))
                {
                    if (command.Contains("odd"))
                    {
                        IndexOfMinOdd(arr);
                    }
                    else if (command.Contains("even"))
                    {
                        IndexOfMinEven(arr);
                    }
                }
                else if (command.Contains("first"))
                {
                    string[] firstElements = command.Split().ToArray();
                    string input = firstElements[1];
                    if (command.Contains("even"))
                    {
                        FirstEvenElements(arr,input);
                    }
                    else if (command.Contains("odd"))
                    {
                        FirstOddElements(arr,input);
                    }
                }
                else if (command.Contains("last"))
                {
                    string[] firstElements = command.Split().ToArray();
                    string input = firstElements[1];
                    if (command.Contains("even"))
                    {
                        LastEvenElements(arr,input);
                    }
                    else if (command.Contains("odd"))
                    {
                        LastOddElements(arr,input);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ",arr)}]");
        }
        //exchange {index} – splits the array after the given index,
        //and exchanges the places of the two resulting sub-arrays.E.g.
        //[1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
        ////If the index is outside the boundaries of the array, print "Invalid index"
        static string IndexExchangeArray(int[] arr, string input)
        {
            int splitIndex = int.Parse(input);
            if (splitIndex>arr.Length-1||splitIndex<0)
            {
                Console.WriteLine("Invalid index");
                return string.Join(' ',arr);
            }
            else
            {
                int[] arrAfterIndex=new int[arr.Length-splitIndex-1];
                int[] newArr=new int[arr.Length];
                int itemsBeforeIndex = 0;
                for (int i = 0; i <= splitIndex; i++)
                {
                    itemsBeforeIndex++;
                }

                int[] arrBeforeIndex = new int[itemsBeforeIndex];
                for (int i = 0; i <= splitIndex; i++)
                {
                    arrBeforeIndex[i]=arr[i];
                }

                for (int i = splitIndex+1; i < arr.Length; i++)
                {
                    arrAfterIndex[i-splitIndex-1]=arr[i];
                }

                for (int i = 0; i < arrAfterIndex.Length; i++)
                {
                    newArr[i]=arrAfterIndex[i];
                }

                for (int i = 0; i < arrBeforeIndex.Length; i++)
                {
                    newArr[i+(arrAfterIndex.Length)]=arrBeforeIndex[i];
                }

                string exchangedArray =string.Join(" ", newArr);
                return exchangedArray;
            }
             
        }
        
        //max even/odd – returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
        static void IndexOfMaxOdd(int[] arr)
        {
            
            int maxOdd = int.MinValue;
            int maxOddIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2!=0)
                {
                    if (arr[i]>=maxOdd)
                    {
                        maxOddIndex = i;
                        maxOdd=arr[i];
                    }
                }
            }

            if (maxOdd==int.MinValue&&maxOddIndex==-1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddIndex);
            }
        }
        static void IndexOfMaxEven(int[] arr)
        {
            
            int maxEven = int.MinValue;
            int maxEvenIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= maxEven)
                    {
                        maxEvenIndex = i;
                        maxEven=arr[i];
                    }
                }
            }

            if (maxEven == int.MinValue&&maxEvenIndex==-1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenIndex);
            }
        }
        static void IndexOfMinOdd(int[] arr)
        {
            
            int minOdd = int.MaxValue;
            int minOddIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] <= minOdd)
                    {
                        minOddIndex = i;
                        minOdd=arr[i];
                    }
                }
            }
            
            if (minOdd == int.MaxValue&&minOddIndex==-1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddIndex);
            }
        }
        static void IndexOfMinEven(int[] arr)
        {
            
            int minEven = int.MaxValue;
            int minEvenIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= minEven)
                    {
                        minEvenIndex = i;
                        minEven=arr[i];
                    }
                }
            }

            if (minEven == int.MaxValue&&minEvenIndex==-1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenIndex);
            }
        }
        //min even/odd – returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
        //If there are two or more equal min/max elements, return the index of the rightmost one
        //If a min/max even/odd element cannot be found, print "No matches"
        //first {count} even / odd – returns the first {count} elements-> [1, 8, 2, 3]->first 2 even->print[8, 2]
        ////•	last
        //{ count}
        //even / odd – returns the last {count} elements-> [1, 8, 2, 3]->last 2 odd->print[1, 3]
        //o If the count is greater than the array length, print "Invalid count"
        //o	If there are not enough elements to satisfy the count, print as many as you can.
        //If there are zero even/odd elements, print an empty array “[]”
        //•	end – stop taking input and print the final state of the array
        static void FirstEvenElements(int[] arr,string input)
        {
            int count = int.Parse(input);
            int counter = 0;
            int[] firstEven = new int[count];
            if (count>arr.Length||count<0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i]%2==0)
                    {
                        
                        if (counter<=firstEven.Length-1)
                        {
                            firstEven[counter] = arr[i];
                        }counter++;
                    }
                }

                if (counter<count)
                {
                    int[] finalArray4 = new int[counter];
                for (int i = 0; i < finalArray4.Length; i++)
                {
                    finalArray4[i] = firstEven[i];
                }

                firstEven = finalArray4;
                }
                
                if (counter==0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ",firstEven)}]");
                }
                
            }

        }
        static void FirstOddElements(int[] arr, string input)
        {
            int count = int.Parse(input);
            int counter = 0;
            int[] firstOdd = new int[count];
            if (count > arr.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        
                        if (counter <= firstOdd.Length - 1)
                        {
                            firstOdd[counter] = arr[i];
                        }
                        counter++;
                    }
                }

                if (counter < count)
                {
                    int[] finalArray3 = new int[counter];
                for (int i = 0; i < finalArray3.Length; i++)
                {
                    finalArray3[i] = firstOdd[i];
                }
                    firstOdd = finalArray3;
                }
                
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", firstOdd)}]");
                }
            }

        }
        static void LastEvenElements(int[] arr, string input)
        {
            int count = int.Parse(input);
            int counter = 0;
            int[] lastEven = new int[count];
            if (count > arr.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = arr.Length-1; i >=0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        
                        if (counter <= lastEven.Length - 1)
                        {
                            lastEven[counter] = arr[i];
                        }counter++;
                    }
                }

                
                
                if (counter<count)
                {
                   int[] finalArray2 = new int[counter];
                for (int i = 0; i < finalArray2.Length; i++)
                {
                    finalArray2[i] = lastEven[i];
                }
                
                lastEven = finalArray2; 
                }
                Array.Reverse(lastEven);
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", lastEven)}]");
                }
            }

        }
        static void LastOddElements(int[] arr, string input)
        {
            int count = int.Parse(input);
            int counter = 0;
            int[] lastOdd = new int[count];
            if (count > arr.Length || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = arr.Length-1; i >=0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        
                        if (counter <= lastOdd.Length - 1)
                        {
                            lastOdd[counter] = arr[i];
                        }counter++;
                    }
                }

                
                if (counter<count)
                {
                   int[] finalArray = new int[counter];
                for (int i = 0; i < finalArray.Length; i++)
                {
                    finalArray[i] = lastOdd[i];
                }

                lastOdd = finalArray; 
                }
                Array.Reverse(lastOdd);
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", lastOdd)}]");
                }
            }

        }
        

    }
}
