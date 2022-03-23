using System;
using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output=new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currChar=input[i];
                if (currChar=='>')
                {
                    int currBombPower = GetIntValueOfChar(input[i+1]);
                    output.Append(currChar);
                    bombPower+=currBombPower;
                }
                else
                {
                    if (bombPower>0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        output.Append(currChar);
                    }
                }
            }
            Console.WriteLine(output);
        }

        static int GetIntValueOfChar(char ch)
        {
            return (int) ch - 48;
        }
    }
}
