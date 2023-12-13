using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.InputValidators
{
    public static class ByteInputValidator
    {
        public static byte ByteInput(string text)
            
        {
            byte ByteNumber;
            while (true)
            {
                Console.Write(text);

                try
                {

                    ByteNumber = Convert.ToByte(Console.ReadLine());
                    if (ByteNumber <= 100)
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Write numbers between 0 and 100.");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ERROR: Write only betweeem numbers 0 and 255");
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

            return ByteNumber;




        }


    }
}
