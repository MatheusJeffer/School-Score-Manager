using System;
using System.Collections.Generic;

namespace Gerenciador_de_notas_de_alunos.InputValidators
{
    public static class DoubleInputValidator
    {
        public static double GetDouble(string txt, double MaxScr, double minScr)
        {
            double DoubleInput;


            while (true)
            {
                Console.Write(txt);

                try
                {
                    DoubleInput = Convert.ToDouble(Console.ReadLine());
                    if (DoubleInput <= MaxScr && DoubleInput > minScr)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Write numbers between 0.1 and 10.5.");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ERROR: You're writing numbers beyond allowed.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Write only numbers.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex}");
                }
            }

            return DoubleInput;


        }
    }
}
