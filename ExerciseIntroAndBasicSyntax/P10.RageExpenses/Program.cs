using System;

namespace P10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	On the first input line - lost games count – integer in the range[0, 1000].
            //•	On the second line – headset price -the floating - point number in the range[0, 1000]. 
            //•	On the third line – mouse price -the floating - point number in the range[0, 1000]. 
            //•	On the fourth line – keyboard price -the floating - point number in the range[0, 1000]. 
            //•	On the fifth line – display price -the floating - point number in the range[0, 1000]. 
            int gamesLost = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            //Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 1; i <= gamesLost; i++)
            {
                if (i%2==0&&i!=0)
                {
                    headsetCount++;
                }

                if (i%3==0 && i != 0)
                {
                    mouseCount++;
                }

                if (i%2==0&&i%3==0 && i != 0)
                {
                    keyboardCount++;
                }

                if (keyboardCount%2==0&&keyboardCount!=0&&i % 2 == 0 && i % 3 == 0)
                {
                    displayCount++;
                }
            }

            double expenses = headset * headsetCount + mouseCount * mouse + keyboardCount * keyboard +
                              displayCount * display;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
