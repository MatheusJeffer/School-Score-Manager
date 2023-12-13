using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos
{
    public static class StringValidator
    {
        public static string StringInputValidator(string text)
        {
            
            string StringInput;
            int SymbolsQuantity;
            char[] Allsymbols = { '!', '@', '#', '^',  '(', ')', '*', '?', '%', '&',
            '_',  '{', '}', '[', ']', ':', ';', ',', '"',  '.', '\\', '\''
            , '.', '|'}; 
            while (true)
            {
                SymbolsQuantity = 0;

                Console.Write(text);
                StringInput = Console.ReadLine().TrimStart(); 

                for (int i = 0; i < StringInput.Length; i++)
                {
                    if (Allsymbols.Contains(StringInput[i]))
                    {
                        SymbolsQuantity++;
                    }

                }

                if (StringInput.Length < 4 || StringInput.Length > 50)
                {
                    Console.WriteLine("Write name above three letters and smaller what twenty letters.");
                }
                else if (StringInput.Any(char.IsNumber))
                {
                    Console.WriteLine("Write only letters.");
                }
                else if( SymbolsQuantity > 0 || StringInput.Any(char.IsSymbol))
                {
                    Console.WriteLine("Write only letters.");
                }
                else
                {
                    break;
                }
            }

            return StringInput;
        } 

    }
}
