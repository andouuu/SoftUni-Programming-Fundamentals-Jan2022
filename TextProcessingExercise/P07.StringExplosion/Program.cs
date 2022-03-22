using System;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int explosionPower=0;
            string explosion="";
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]=='>')
                {
                    
                    explosionPower += (int)char.GetNumericValue(input[i+1]);
                    if (i+1+explosionPower<input.Length)
                    {
                        if (input.Substring(i + 1, explosionPower).Contains('>'))
                        {
                            for (int j = i + 1; j < explosionPower + i + 1; j++)
                            {
                                if (j > input.Length - 1)
                                {
                                    break;
                                }
                                else
                                {
                                    if (input[j] != '>')
                                    {

                                        if (explosionPower > 0)
                                        {
                                            input = input.Remove(j, 1);
                                            explosionPower--;
                                        }
                                    }
                                    else
                                    {
                                        explosionPower += (int)char.GetNumericValue(input[j + 1]);

                                    }
                                }

                            }
                        }
                        else
                        {
                            if (i + 1 + explosionPower > input.Length - 1)
                            {
                                input.Remove(i + 1);
                            }
                            else
                            {
                                input = input.Remove(i + 1, explosionPower);
                                explosionPower = 0;
                            }



                        }
                    }
                    else
                    {
                        if (input.Substring(i + 1).Contains('>'))
                        {
                            for (int j = i + 1; j < explosionPower + i + 1; j++)
                            {
                                if (j > input.Length - 1)
                                {
                                    break;
                                }
                                else
                                {
                                    if (input[j] != '>')
                                    {

                                        if (explosionPower > 0)
                                        {
                                            input = input.Remove(j, 1);
                                            explosionPower--;
                                        }
                                    }
                                    else
                                    {
                                        explosionPower += (int)char.GetNumericValue(input[j + 1]);

                                    }
                                }
                            }
                        }
                        else
                        {
                            if (i + 1 + explosionPower > input.Length - 1)
                            {
                                input.Remove(i + 1);
                            }
                            else
                            {
                                input = input.Remove(i + 1, explosionPower);
                                explosionPower = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
