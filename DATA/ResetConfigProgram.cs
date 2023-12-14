using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Score_Manager.InputValidators;

namespace Score_Manager.Data
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
                    courseQuantity = ByteInputValidator.ByteInput("Write numbers of course: ", 0, 15);
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
                    cicleAll = ByteInputValidator.ByteInput("Write quantity f cicles: ", 0, 4);
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
