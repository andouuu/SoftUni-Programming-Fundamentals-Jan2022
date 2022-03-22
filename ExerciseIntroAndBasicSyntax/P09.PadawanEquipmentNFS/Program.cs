using System;

namespace P09.PadawanEquipmentNFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int amountOfStudents = int.Parse(Console.ReadLine());
            double priceForSaber = double.Parse(Console.ReadLine());
            double priceForRobe = double.Parse(Console.ReadLine());
            double priceForBelt = double.Parse(Console.ReadLine());
            double freeBelts = 0;
            if (amountOfStudents>=6)
            {
              freeBelts = Math.Floor((double)amountOfStudents / 6);  
            }
            
            double fullPrice = priceForSaber * Math.Ceiling(amountOfStudents + amountOfStudents * 0.10) +
                               priceForRobe * (amountOfStudents) + priceForBelt * (amountOfStudents - freeBelts);
            if (amountOfMoney-fullPrice>=0)
            {
                Console.WriteLine($"The money is enough - it would cost {fullPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {fullPrice-amountOfMoney:f2}lv more.");
            }
        }
    }
}
