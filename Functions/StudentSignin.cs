using System;
using Gerenciador_de_notas_de_alunos.DATA;
using Gerenciador_de_notas_de_alunos.InputValidators;

namespace Gerenciador_de_notas_de_alunos.Functions
{
    public class StudentSignin : ProgramData
    {

        public static void SignIn(int StudentQuantity)
        {
            for (int student = 0; student < StudentQuantity; student++)
            {

                allScores.Add(new List<List<double>> { });
                StudentNameArray.Add(StringValidator.StringInputValidator("Write the name of student: "));

                for (int course = 0; course < quantityCourses; course++)
                {
                    allScores[NumberStudent].Add(new List<double> { });
                    allScores[NumberStudent][course].Add(TypeCalculatorScr.TypeScr(country, course));



                }
                NumberStudent++;
            }
        }
    }       

        
    
}
