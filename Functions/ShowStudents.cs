using Score_Manager.Data;
using System;
using System.Collections.Generic;

namespace Score_Manager.Functions
{
    public class ShowStudents
    {
        public static void AllStudent()
        {
            int index = 0;

            for(int student = 0; student < ProgramData.StudentNameArray.Count; student++)
            {
                index = 0;
                Console.WriteLine($"{student}°.{ProgramData.StudentNameArray[student]}: ");

                for (int course = 0; course < ProgramData.quantityCourses; course++)
                {
                    for (int cicle = 0; cicle < ProgramData.cicleQuantity; cicle++)
                    {

                        Console.WriteLine($"  {ProgramData.courses[index]}: [ {ProgramData.allScores[student][course][cicle]:f2} ] ");
                    }
                    index++;
                }

            }
        }
    }
}
