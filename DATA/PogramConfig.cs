using Gerenciador_de_notas_de_alunos.InputValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.DATA
{
    public class PogramConfig : ProgramData
    {

        public static void ConfigurationProgram()
        {

            string whatCountry = StringValidator.StringInputValidator("What is your country? ");
            byte coursesQuanti = ByteInputValidator.ByteInput("Write the number of courses: ");
            byte cicles = ByteInputValidator.ByteInput("Write the number of cicles: ");

            courses = new string[coursesQuanti];

            cicleQuantity = cicles;
            country = whatCountry;
            quantityCourses = coursesQuanti;
            for (int courseNumber = 0; courseNumber < coursesQuanti; courseNumber++)
            {
                courses[courseNumber] = StringValidator.StringInputValidator("Write name of course: ");
            }



        }
    }
}
