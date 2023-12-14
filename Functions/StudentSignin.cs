using System;
using Score_Manager.Data;
using Score_Manager.InputValidators;

namespace Score_Manager.Functions
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
                    for (int _ = 0; _ < cicleQuantity; _++)
                    {
                        allScores[NumberStudent][course].Add(0);

                    }

                }
                NumberStudent++;
            }
        }
    }       

        
    
}
