using Gerenciador_de_notas_de_alunos.DATA;
using System;
using System.Collections.Generic;

namespace Gerenciador_de_notas_de_alunos.Functions
{
    public class ShowStudents
    {
        public static void AllStudent()
        {
            int index = 0;

            for(int Student = 0; Student < ProgramData.StudentNameArray.Count; Student++)
            {
                index = 0;
                Console.WriteLine($"{Student}°.{ProgramData.StudentNameArray[Student]}: ");

                for (int course = 0; course < ProgramData.quantityCourses; course++)
                    foreach ( var scr in ProgramData.allScores[Student][course])
                    {
    
                        Console.WriteLine($"  {ProgramData.courses[index]}: [ {scr:f1} ] ");
                        index++;
                    }

                Console.WriteLine(" ");
            }
        }
    }
}
