using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace P07.StudentAcademy
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
           Dictionary<string,List<double>> students=new Dictionary<string,List<double>>();
           int n = int.Parse(Console.ReadLine());
           for (int i = 0; i < n; i++)
           {
               
               string name = Console.ReadLine();
               double grade = double.Parse(Console.ReadLine());
               if (!students.ContainsKey(name))
               {
                   List<double> newList = new List<double>() {grade};
                   students.Add(name, newList);
               }
               else
               {
                   students[name].Add(grade);
               }
           }

           foreach (var student in students)
           {
               if (student.Value.Average()<4.50)
               {
                   students.Remove(student.Key);
               }
               
           }

           foreach (var student in students)
           {
               Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
           }
        }
    }
}
