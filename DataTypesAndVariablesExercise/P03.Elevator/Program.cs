using System;

namespace P03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            while(people>=capacity) 
            {
                people-=capacity;
                courses++;
            }
            if (people<capacity&&people!=0)
                {
                    courses += 1;
                }

            Console.WriteLine(courses);
        }
    }
}
