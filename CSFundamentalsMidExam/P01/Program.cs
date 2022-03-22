using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int numberOfBiscuitsOfCompetingFactory=int.Parse(Console.ReadLine());
            int numOfBiscuit = 0;
            for (int i = 1; i <= 30; i++)
            {
                double biscuitsThisDay;
                if (i%3==0)
                {
                    biscuitsThisDay = Math.Floor(numberOfWorkers * biscuitsPerDayPerWorker * 0.75);
                    numOfBiscuit+=(int)biscuitsThisDay;

                }
                else
                {
                    biscuitsThisDay = numberOfWorkers * biscuitsPerDayPerWorker;
                    numOfBiscuit += (int)biscuitsThisDay;
                }
            }

            double percentageDifference = (Math.Abs(numOfBiscuit-numberOfBiscuitsOfCompetingFactory)
                *1.00/numberOfBiscuitsOfCompetingFactory*1.00)*100;
            if (numOfBiscuit>numberOfBiscuitsOfCompetingFactory)
            {
                Console.WriteLine($"You have produced {numOfBiscuit} biscuits for the past month.");
                Console.WriteLine($"You produce {Math.Abs(percentageDifference):f2} percent more biscuits.");
            }
            else if (numOfBiscuit < numberOfBiscuitsOfCompetingFactory)
            {
                Console.WriteLine($"You have produced {numOfBiscuit} biscuits for the past month.");
                Console.WriteLine($"You produce {Math.Abs(percentageDifference):f2} percent less biscuits.");
            }
        }
    }
}
