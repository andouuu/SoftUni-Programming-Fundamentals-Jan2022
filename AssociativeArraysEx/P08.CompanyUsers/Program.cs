using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CompanyUsers
{
    class Company
    {
        public Company( List<string> ppl)
        {
            
            Ppl = ppl;
        }
        
        public List<string> Ppl { get; set; }
        public override string ToString()
        {
            string output = null;
            
            foreach (var person in Ppl)
            {
                output += Environment.NewLine;
                output += $"-- {person}";
            }
            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personToAdd = input.Split(" -> ").ToArray();
                if (companies.ContainsKey(personToAdd[0]))
                {
                    
                    
                    if (!companies[personToAdd[0]].Ppl.Contains(personToAdd[1]))
                    {
                       companies[personToAdd[0]].Ppl.Add(personToAdd[1]); 
                    }
                }
                else
                {
                    List<string> ppl = new List<string>() { personToAdd[1] };
                    Company currCompany = new Company(ppl);

                    companies.Add(personToAdd[0], currCompany);
                }
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}{kvp.Value}");
            }
        }
    }
}
