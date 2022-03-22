using System;
using System.Collections.Generic;
using System.Linq;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bookShelf = Console.ReadLine().Split("&").ToList();
            string input;
            while ((input=Console.ReadLine())!="Done")
            {
                string[] command = input.Split(" | ").ToArray();
                if (command.Contains("Add Book"))
                {
                    if (!bookShelf.Contains(command[1]))
                    {
                        bookShelf.Reverse();
                        bookShelf.Add(command[1]);
                        bookShelf.Reverse();
                    }
                }
                else if (command.Contains("Take Book"))
                {
                    if (bookShelf.Contains(command[1]))
                    {
                        bookShelf.Remove(command[1]);
                    }
                }
                else if(command.Contains("Swap Books"))
                {
                    if (bookShelf.Contains(command[1])&&bookShelf.Contains(command[2]))
                    {
                        string firstBook = command[1];
                        string secondBook = command[2];
                        for (int i = 0; i < bookShelf.Count; i++)
                        {
                            if (bookShelf[i]==command[1])
                            {
                                bookShelf.RemoveAt(i);
                                bookShelf.Insert(i,secondBook);
                                
                                
                            }
                            else if (bookShelf[i]==command[2])
                            {
                                bookShelf.RemoveAt(i);
                                bookShelf.Insert(i, firstBook);
                                
                            }
                        }
                    }
                }
                else if (command.Contains("Insert Book"))
                {
                    if (!bookShelf.Contains(command[1]))
                    {
                        bookShelf.Add(command[1]);
                    }
                }
                else if (command.Contains("Check Book"))
                {
                    if (int.Parse(command[1])>0&&int.Parse(command[1])<=bookShelf.Count-1)
                    {
                        Console.WriteLine(bookShelf[int.Parse(command[1])]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",bookShelf));
        }
    }
}
