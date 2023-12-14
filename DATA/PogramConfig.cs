using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Score_Manager.InputValidators;

namespace Score_Manager.Data
{
    public class PogramConfig : ProgramData
    {

        public static void ConfigurationProgram()
        {

            string whatCountry = StringValidator.StringInputValidator("What is your country? ");
            byte coursesQuanti = ByteInputValidator.ByteInput("Write the number of courses: ", 0, 15);
            byte cicles = ByteInputValidator.ByteInput("Write the number of cicles: ", 0, 4);
            double scoreConfig = DoubleInputValidator.GetDouble("Write the max score: ", 100.00, 5.00);

            courses = new string[coursesQuanti];

            cicleQuantity = cicles;
            country = whatCountry;
            quantityCourses = coursesQuanti;
            maxScore = scoreConfig;

            for (int courseNumber = 0; courseNumber < coursesQuanti; courseNumber++)
            {
                courses[courseNumber] = StringValidator.StringInputValidator("Write name of course: ");
            }



        }
    }
}
