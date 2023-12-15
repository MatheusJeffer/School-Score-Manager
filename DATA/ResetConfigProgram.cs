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

        public static void resetConfig()
        {
            byte courseQuantity = 0;
            byte cicleAll = 0;
            string countryName = " ";
            byte userChoose = 0; 

            Console.WriteLine("Choose configuration for reset:\n [1]Reset course quantity and add more courses.\n" +
                                      " [2]Reset cicles quantity\n [3]Reset country\n");
            userChoose = ByteInputValidator.ByteInput("Select: ", 0, 3);

            switch (userChoose)
            {
                case 1:
                    courseQuantity = ByteInputValidator.ByteInput("Write numbers of course: ", 0, 15);
                    quantityCourses = courseQuantity;
                    courses = new string[courseQuantity];
                    allScores.Clear();
                    StudentNameArray.Clear();
                    NumberStudent = 0;

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
                case 4:



                    break;
                default:
                    Console.WriteLine("This option not exists.");
                    break;
            }



        }
    }
}
