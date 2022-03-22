using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    class Course
    {
        public Course(int numOfPpl,List<string> ppl)
        {
            NumOfPpl=numOfPpl;
            Ppl=ppl;
        }
        public int NumOfPpl { get; set; }
        public List<string> Ppl { get; set; }
        public override string ToString()
        {
            string output = null;
            output += $"{NumOfPpl}";
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
            Dictionary<string,Course> courses = new Dictionary<string,Course>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] personToAdd = input.Split(" : ").ToArray();
                if (courses.ContainsKey(personToAdd[0]))
                {
                    courses[personToAdd[0]].NumOfPpl++;
                    courses[personToAdd[0]].Ppl.Add(personToAdd[1]);
                }
                else
                {
                    List<string> ppl = new List<string>() {personToAdd[1]};
                    Course currCourse = new Course(1,ppl);
                    
                    courses.Add(personToAdd[0],currCourse);
                }
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
