using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Score_Manager.Data;
using Score_Manager.InputValidators;
namespace Score_Manager.Functions;

public class AddNewScr : ProgramData
{

    public static void AddNeWScores(int cicle)
    {

        double scoreInput = 0;
        bool loopBreaker = true;
        for (int student = 0; student < StudentNameArray.Count; student++)
        {

            Console.WriteLine($"Student: {StudentNameArray[student]}");
            for (int course = 0; course < quantityCourses; course++)
            {

                if (allScores[student][course][cicle - 1] < maxScore) 
                {
                    do
                    {
                        scoreInput = TypeCalculatorScr.TypeScr(country, course);

                        if (allScores[student][course][cicle - 1] + scoreInput <= maxScore)
                        {

                            allScores[student][course][cicle - 1] += scoreInput;
                            
                            Console.WriteLine($" scores restant {maxScore - allScores[student][course][cicle - 1]:f2}");
                            loopBreaker = false;
                        }
                        else if (allScores[student][course][cicle - 1] + scoreInput > maxScore)
                        {
                            Console.WriteLine($"The score don't pass to {maxScore- allScores[student][course][cicle - 1]:f2}");
                        }
                    } while (loopBreaker);
                }
                else
                {
                    Console.WriteLine($"Score max limit in {courses[course]}");
                }
            }
        }

    }

}
