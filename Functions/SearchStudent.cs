using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Score_Manager.Data;
using Score_Manager.InputValidators;



namespace Score_Manager.Functions
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
                    if (ProgramData.StudentNameArray[student] == studentName)
                    {
                        Console.WriteLine($"{ProgramData.StudentNameArray.IndexOf(studentName)}°." +
                          $"{ProgramData.StudentNameArray[ProgramData.StudentNameArray.IndexOf(studentName)]}  ");

                        for (int course = 0; course < ProgramData.quantityCourses; course++)
                        {
                            Console.Write($"  {ProgramData.courses[course].PadRight(10)}: ");
                            for (int cicles = 0; cicles < ProgramData.cicleQuantity; cicles++)
                            {
                                Console.Write($" [ {ProgramData.allScores[student][course][cicles]:f2} ]");

                            }
                            Console.WriteLine("");
                        }
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
