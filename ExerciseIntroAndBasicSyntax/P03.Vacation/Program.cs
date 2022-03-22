using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPpl = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double totalPrice = 0;
            switch (dayOfTheWeek)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            if (numOfPpl>=30)
                            {
                                totalPrice = numOfPpl * 8.45 - (numOfPpl * 8.45 * 0.15);
                            }
                            else
                            {
                                totalPrice = numOfPpl * 8.45;
                            }
                            break;
                        case "Business":
                            if (numOfPpl>=100)
                            {
                                totalPrice = numOfPpl * 10.90 - 10.90 * 10;
                            }
                            else
                            {
                                totalPrice=numOfPpl*10.90;
                            }
                            break;
                        case "Regular":
                            if (numOfPpl>=10&&numOfPpl<=20)
                            {
                                totalPrice = numOfPpl * 15.00 - (numOfPpl * 15.00 * 0.05);
                            }
                            else
                            {
                                totalPrice = numOfPpl * 15.00;
                            }
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            if (numOfPpl >= 30)
                            {
                                totalPrice = numOfPpl * 9.80 - (numOfPpl * 9.80 * 0.15);
                            }
                            else
                            {
                                totalPrice = numOfPpl * 9.80;
                            }
                            break;
                        case "Business":
                            if (numOfPpl >= 100)
                            {
                                totalPrice = numOfPpl * 15.60 - 15.60 * 10;
                            }
                            else
                            {
                                totalPrice = numOfPpl * 15.60;
                            }
                            break;
                        case "Regular":
                            if (numOfPpl >= 10 && numOfPpl <= 20)
                            {
                                totalPrice = numOfPpl * 20.00 - (numOfPpl * 20.00 * 0.05);
                            }
                            else
                            {
                                totalPrice = numOfPpl * 20.00;
                            }
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            if (numOfPpl >= 30)
                            {
                                totalPrice = numOfPpl * 10.46 - (numOfPpl * 10.46 * 0.15);
                            }
                            else
                            {
                                totalPrice = numOfPpl * 10.46;
                            }
                            break;
                        case "Business":
                            if (numOfPpl >= 100)
                            {
                                totalPrice = numOfPpl * 16.00 - 16.00 * 10;
                            }
                            else
                            {
                                totalPrice = numOfPpl * 16.00;
                            }
                            break;
                        case "Regular":
                            if (numOfPpl >= 10 && numOfPpl <= 20)
                            {
                                totalPrice = numOfPpl * 22.50 - (numOfPpl * 22.50 * 0.05);
                            }
                            else
                            {
                                totalPrice = numOfPpl * 22.50;
                            }
                            break;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
