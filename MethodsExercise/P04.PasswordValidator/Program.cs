using System;
using System.Linq;

namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string password = Console.ReadLine();
            PasswordValidate(password);
        }

        static bool LengthValidate(string input)
        {
            if (input.Length>=6&&input.Length<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CharactersValidate(string input)
        {
            bool isDigitOrLetter = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetterOrDigit(input[i]))
                {
                    
                }
                else
                {
                    isDigitOrLetter=false;
                }
            }
            return isDigitOrLetter;
        }

        static bool DigitValidate(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    counter++;
                }
            }

            if (counter>=2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PasswordValidate(string input)
        {
            if (!LengthValidate(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");  
            }

            if (!CharactersValidate(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!DigitValidate(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CharactersValidate(input)&&LengthValidate(input)&&DigitValidate(input))
            {
                Console.WriteLine("Password is valid");
            }
        }
//"Password must be between 6 and 10 characters"
            //"Password must consist only of letters and digits"
            //"Password must have at least 2 digits"
    }
}
