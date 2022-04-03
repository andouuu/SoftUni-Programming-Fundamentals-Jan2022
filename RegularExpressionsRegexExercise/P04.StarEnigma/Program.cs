using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patternForCount = @"[STARstar]";
            Regex countRegex=new Regex(patternForCount);
            string patternEncryptedMess =
                @".*?@([A-Za-z]+)[^@\-!:>]*?:[^@\-!:>]*?(\d*)[^@\-!:>]*?![^@\-!:>]*?([AD]{1})[^@\-!:>]*?![^@\-!:>]*?-[^@\-!:>]*?>[^@\-!:>]*?(\d+).*";
            Regex encryptedMessRegex = new Regex(patternEncryptedMess);
            List<string> attackedPlanets=new List<string>();
            List<string> destroyedPlanets=new List<string>();
            for (int i = 0; i < n; i++)
            {
                string currMessage= Console.ReadLine();
                int countSTAR=countRegex.Matches(currMessage).Count;
                string currPlanet = "";
                foreach (var ch in currMessage)
                {
                    currPlanet += char.ConvertFromUtf32(ch - countSTAR);
                }

                if (encryptedMessRegex.IsMatch(currPlanet))
                {
                    Match currMatch = encryptedMessRegex.Match(currPlanet);
                    if (currMatch.Groups[3].Value=="A")
                    {
                        attackedPlanets.Add(currMatch.Groups[1].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(currMatch.Groups[1].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
