using System;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            int over9 = 0;
            string finalNumber = string.Empty;
            for (int i = firstNumber.Length-1; i >=0; i--)
            {
                string last = firstNumber[i].ToString();
                int currNumber=int.Parse(last);
                int multipliedNums = secondNumber * currNumber;
                int numToInsert = multipliedNums%10 + over9%10;
                if (multipliedNums>9)
                {
                    
                    if (over9>9)
                    {
                        over9 /= 10;
                    }
                    else
                    {
                        over9 = 0;
                    }
                    if (numToInsert>9)
                    {
                        finalNumber=finalNumber.Insert(0, (numToInsert%10).ToString());
                        
                        over9 += multipliedNums/10+numToInsert/10;
                        
                    }
                    else
                    {
                        finalNumber=finalNumber.Insert(0, (numToInsert).ToString());
                        
                        over9 += multipliedNums / 10;
                        
                    }
                    
                   
                }
                else
                {
                    if (over9 > 9)
                    {
                        over9 /= 10;
                    }
                    else
                    {
                        over9 = 0;
                    }
                    if (numToInsert > 9)
                    {
                        finalNumber = finalNumber.Insert(0, (numToInsert % 10).ToString());

                        over9 += numToInsert / 10;
                        
                    }
                    else
                    {
                        finalNumber = finalNumber.Insert(0, (numToInsert).ToString());
                    }


                }
                
            }

            if (over9!=0)
            {
               finalNumber = finalNumber.Insert(0, over9.ToString()); 
            }

            if (secondNumber==0)
            {
                Console.WriteLine(0);
            }
            else
            {
               Console.WriteLine(finalNumber); 
            }
            
        }
    }
}
