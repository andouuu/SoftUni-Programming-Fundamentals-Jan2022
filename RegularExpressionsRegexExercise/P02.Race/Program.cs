using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string,int> participants=new Dictionary<string,int>();
            foreach (var participant in input)
            {
                participants.Add(participant,0);
            }

            string pattern = @"[A-Za-z0-9]";
            Regex regex = new Regex(pattern);

            string cmd = Console.ReadLine();
            while (cmd!="end of race")
            {
                string nameOfCurrParticipant=string.Empty;
                int currParticipantDistance=0;
                MatchCollection matches= regex.Matches(cmd);
                foreach (Match match in matches)
                {
                    if (char.IsLetter(char.Parse(match.ToString())))
                    {
                        nameOfCurrParticipant += match.ToString();
                    }
                    else if (char.IsDigit(char.Parse(match.ToString())))
                    {
                        currParticipantDistance += int.Parse(match.ToString());
                    }
                }

                if (participants.ContainsKey(nameOfCurrParticipant))
                {
                    participants[nameOfCurrParticipant] += currParticipantDistance;
                }

                cmd = Console.ReadLine();
            }
            
            List<KeyValuePair<string,int>> orderedParticipants = participants.OrderByDescending(x=>x.Value).ToList();
            Console.WriteLine($"1st place: {orderedParticipants[0].Key}");
            Console.WriteLine($"2nd place: {orderedParticipants[1].Key}");
            Console.WriteLine($"3rd place: {orderedParticipants[2].Key}");
        }
    }
}
