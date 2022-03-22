using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.TeamworkProjects
{
    internal class Program
    {
        class Team
        {
            public string TeamName { get; set; }
            public string TeamCreator { get; set; }
            public List<string> TeamMembers = new List<string>();

            public void PrintTeam()
            {
                //"{teamName}
                //- { creator}
                //-- { member}…"
                Console.WriteLine($"{TeamName}");
                Console.WriteLine($"- {TeamCreator}");
                foreach (var member in TeamMembers.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }

            }
        }
        static void Main(string[] args)
        {
            List<Team> teams=new List<Team>();
            List<Team> disbandedTeams= new List<Team>();
            List<string> registeredTeamNames = new List<string>();
            List<string> registeredTeamMembers = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command=Console.ReadLine().Split("-").ToArray();
                Team team=new Team();
                team.TeamCreator=command[0];
                team.TeamName=command[1];
                int counter = 0;
                foreach (var t in teams)
                {
                    if (t.TeamCreator==team.TeamCreator)
                    {
                        Console.WriteLine($"{team.TeamCreator} cannot create another team!");
                        counter++;
                        
                    }

                    if (t.TeamName==team.TeamName)
                    {
                        Console.WriteLine($"Team {team.TeamName} was already created!");
                        counter++;
                    }
                }

                if (counter>0)
                {
                    continue;
                }
                teams.Add(team);
                registeredTeamNames.Add(team.TeamName);
                registeredTeamMembers.Add(team.TeamCreator);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.TeamCreator}!");
            }

            string input;
            while ((input=Console.ReadLine())!="end of assignment")
            {
                string[] userToJoin=input.Split("->").ToArray();
                string member = userToJoin[0];
                string teamToJoin = userToJoin[1];
                if (!registeredTeamNames.Contains(teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }

                if (registeredTeamMembers.Contains(member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    continue;
                }

                foreach (var team in teams)
                {
                    if (team.TeamName==teamToJoin)
                    {
                        team.TeamMembers.Add(member);
                    }
                }
                registeredTeamMembers.Add(member);
            }
            
            
            List<Team> sortedTeams=teams.OrderByDescending(t => t.TeamMembers.Count).ThenBy(t=>t.TeamName).ToList();
            
            foreach (var team in sortedTeams)
            {
                if (team.TeamMembers.Count==0)
                {
                    disbandedTeams.Add(team);
                    teams.Remove(team);
                }
                else
                {
                  team.PrintTeam();  
                }
                
            }
            List<Team> sortedDisbandedTeams = disbandedTeams.OrderBy(t=>t.TeamName).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var team in sortedDisbandedTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
