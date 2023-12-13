using Gerenciador_de_notas_de_alunos.InputValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.DATA
{
    public class ResetConfigProgram : ProgramData
    {

        public static void resetConfig(int typeConfig)
        {
            byte courseQuantity = 0;
            byte cicleAll = 0;
            string countryName = " ";
            switch (typeConfig)
            {
                case 1:
                    courseQuantity = ByteInputValidator.ByteInput("Write numbers of course: ");
                    quantityCourses = courseQuantity;
                    courses = new string[courseQuantity];
                    allScores.Clear();
                    StudentNameArray.Clear();

                    for (int index = 0; index < courseQuantity; index++)
                    {
                        courses[index] = StringValidator.StringInputValidator("Write the name of course: ");

                    }

                    break;
                case 2:
                    cicleAll = ByteInputValidator.ByteInput("Write quantity f cicles: ");
                    cicleQuantity = cicleAll;
                    break;
                case 3:
                    countryName = StringValidator.StringInputValidator("Write name of your country: ");
                    country = countryName;
                    break;
                default:
                    Console.WriteLine("This option not exists.");
                    break;
            }



        }
    }
}
