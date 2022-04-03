using System;
using System.Collections.Generic;

namespace P03
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> superHeroes=new Dictionary<string,List<string>>();
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                string[] command = cmd.Split(' ');
                string cmdType=command[0];
                if (cmdType=="Enroll")
                {
                    string heroToEnroll=command[1];
                    if (superHeroes.ContainsKey(heroToEnroll))
                    {
                        Console.WriteLine($"{heroToEnroll} is already enrolled.");
                    }
                    else
                    {
                        superHeroes.Add(heroToEnroll,new List<string>());
                    }
                }
                else if (cmdType == "Learn")
                {
                    string heroToLearnSpell = command[1];
                    string spellToLearn=command[2];
                    if (!superHeroes.ContainsKey(heroToLearnSpell))
                    {
                        Console.WriteLine($"{heroToLearnSpell} doesn't exist.");
                    }
                    else if (superHeroes[heroToLearnSpell].Contains(spellToLearn))
                    {
                        Console.WriteLine($"{heroToLearnSpell} has already learnt {spellToLearn}.");
                    }
                    else
                    {
                        superHeroes[heroToLearnSpell].Add(spellToLearn);
                    }
                }
                else if (cmdType=="Unlearn")
                {
                    string heroToUnlearnSpell = command[1];
                    string spellToUnlearn = command[2];
                    if (!superHeroes.ContainsKey(heroToUnlearnSpell))
                    {
                        Console.WriteLine($"{heroToUnlearnSpell} doesn't exist.");
                    }
                    else if (superHeroes[heroToUnlearnSpell].Contains(spellToUnlearn))
                    {
                        superHeroes[heroToUnlearnSpell].Remove(spellToUnlearn);
                    }
                    else
                    {
                        Console.WriteLine($"{heroToUnlearnSpell} doesn't know {spellToUnlearn}.");
                    }
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var kvp in superHeroes)
            {
                Console.WriteLine($"== {kvp.Key}: {string.Join(", ",kvp.Value)}");   
            }
        }
    }
}
