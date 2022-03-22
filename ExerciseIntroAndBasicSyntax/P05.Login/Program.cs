using System;
using System.Linq;

namespace P05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username=Console.ReadLine();
            string password = null;
            int counter = 0;
            for (int i = username.Length-1; i >=0; i--)
            {
                password += username[i];
            }

            while (counter<=4)
            {
                string tryPass = Console.ReadLine();
                
                
                if (tryPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                counter++; 
                if (counter==4)
                {   
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                
                Console.WriteLine($"Incorrect password. Try again.");
                
                
            }

            
            
        }
    }
}
