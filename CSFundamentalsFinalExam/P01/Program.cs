using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cmd;
            while ((cmd=Console.ReadLine())!="Done")
            {
                string[] command=cmd.Split(' ');
                string cmdType=command[0];
                if (cmdType=="Change")
                {
                    char charToReplace = char.Parse(command[1]);
                    char newChar = char.Parse(command[2]);
                    input=input.Replace(charToReplace, newChar);
                    Console.WriteLine(input);
                }
                else if (cmdType=="Includes")
                {
                    string subString=command[1];
                    bool doesItContain = input.Contains(subString);
                    Console.WriteLine(doesItContain);
                }
                else if (cmdType=="End")
                {
                    string endingSubString=command[1];
                    bool doesItEndWith = input.EndsWith(endingSubString);
                    Console.WriteLine(doesItEndWith);
                }
                else if (cmdType=="Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (cmdType=="FindIndex")
                {
                    char ch = char.Parse(command[1]);
                    int index = input.IndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (cmdType=="Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    input = input.Substring(startIndex, count);
                    Console.WriteLine(input);
                }
            }
        }
    }
}
