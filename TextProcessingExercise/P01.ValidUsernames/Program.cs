using System;
using System.Linq;

namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var username in input)
            {
                int countInvalid = 0;
                if (username.Length>3&&username.Length<16)
                {
                    
                    foreach (var ch in username)
                    {
                       if (ch!='-'&&ch!='_'&&!char.IsLetter(ch) && !char.IsDigit(ch))
                       {
                           countInvalid++;
                           break;
                           
                       } 
                    }

                    if (countInvalid==0)
                    {
                        Console.WriteLine(username);
                    }
                    
                    
                }
            }
        }
    }
}
