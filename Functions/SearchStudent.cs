﻿using Gerenciador_de_notas_de_alunos.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.Functions
{
    public class SearchStudent
    {
        public static void Search()
        {
            string studentName;
            int index = 0;
            studentName = StringValidator.StringInputValidator("Write name of student: ");

            if (ProgramData.StudentNameArray.Contains(studentName))
            {
                        Console.WriteLine($"{ProgramData.StudentNameArray.IndexOf(studentName)}°." +
                            $"{ProgramData.StudentNameArray[ProgramData.StudentNameArray.IndexOf(studentName)]}  ");


                for (int student = 0; student < ProgramData.StudentNameArray.Count; student++)
                {
                    for (int course = 0; course < ProgramData.quantityCourses; course++)
                    {
                        Console.WriteLine($"  {ProgramData.courses[index].PadRight(10)} : [ {ProgramData.allScores[student][course][1]} ]");

                    }
                } 
           
            }
            else
            {
                Console.WriteLine("This name don't registered.");
            }
        }
    }
}
