﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Score_Manager.Data;
using Score_Manager.InputValidators;
namespace Score_Manager.Functions;

public class AddNewScr : ProgramData
{

    public static void AddNeWScores()
    {
        StudentData saveDataList = new StudentData();

        double scoreInput = 0;
        bool loopBreaker = true;
        for (int student = 0; student < StudentNameArray.Count; student++)
        {

            Console.WriteLine($"Student: {StudentNameArray[student]}");
            for (int course = 0; course < quantityCourses; course++)
            {
                if (allScores[student][course][currentCicle] < maxScore) 
                {
                    while (true)
                    {


                        scoreInput = TypeCalculatorScr.TypeScr(country, course);

                        if (allScores[student][course][currentCicle] + scoreInput <= maxScore)
                        {

                            allScores[student][course][currentCicle] += scoreInput;

                            Console.WriteLine($" scores restant {maxScore - allScores[student][course][currentCicle]:f2}");
                            break;
                        }
                        else if (allScores[student][course][currentCicle] + scoreInput > maxScore)
                        {
                            Console.WriteLine($"The score don't pass to {maxScore - allScores[student][course][currentCicle]:f2}");
                        }
                    }
                }
                else 
                {
                    Console.WriteLine($"Score max limit in {courses[course]}");
                }
            }
        }
        saveDataList.Save();
    }

}
