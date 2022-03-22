using System;
using System.ComponentModel.Design;
using System.Linq;

namespace P10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugs = new int[fieldSize];
            int[] ladyBugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                if (ladyBugsIndexes[i]>=0&&ladyBugsIndexes[i]<=ladyBugs.Length-1)
                {
                  ladyBugs[ladyBugsIndexes[i]] = 1;  
                }
                
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                int ladyBugPlace = int.Parse(command[0]);
                if (ladyBugPlace>=0&&ladyBugPlace<=ladyBugs.Length-1)
                {
                    int flyLength = int.Parse(command[2]);
                    if (ladyBugs[ladyBugPlace]==1)
                    {
                        
                    
                        if (command[1] == "right")
                        {

                            int jumpCount = 1;
                            int finalIndex = ladyBugPlace + flyLength * jumpCount;
                            while (finalIndex <= ladyBugs.Length - 1 && ladyBugs[finalIndex] == 1)
                            {
                                if (flyLength != 0)
                                {
                                    jumpCount++;
                                    finalIndex = ladyBugPlace + flyLength * jumpCount;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (finalIndex < fieldSize)
                            {
                                ladyBugs[finalIndex] = 1;
                            }

                            if (flyLength != 0)
                            {
                                ladyBugs[ladyBugPlace] = 0;
                            }

                        }
                        else if (command[1]=="left")
                        {
                            int timesFlied = 1;
                            int finalIndex = ladyBugPlace - flyLength * timesFlied;
                            while (finalIndex >=0 && ladyBugs[finalIndex] == 1)
                            {
                                if (flyLength != 0)
                                {
                                    timesFlied++;
                                    finalIndex = ladyBugPlace - flyLength * timesFlied;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (finalIndex >=0 )
                            {
                                ladyBugs[finalIndex] = 1;
                            }

                            if (flyLength != 0)
                            {
                                ladyBugs[ladyBugPlace] = 0;
                            }
                            
                        }
                    }
                
                }
            }

            Console.WriteLine(string.Join(' ', ladyBugs));
        }
    }
}