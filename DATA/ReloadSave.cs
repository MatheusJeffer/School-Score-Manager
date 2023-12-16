using Score_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Maps;

namespace Gerenciador_de_notas_de_alunos.Data
{
    public class ReloadSaveSettings : ProgramData
    {

        public virtual void ReadSave()
        {

            const string path = @"C:\Users\Mathe_ss6lb0m\Documents\score manager data\settings.txt";


                using (StreamReader readSettings = new StreamReader(path))
                {
                    country = readSettings.ReadLine();
                    quantityCourses = int.Parse(readSettings.ReadLine());
                    
                    NumberStudent = int.Parse(readSettings.ReadLine());
                    cicleQuantity = int.Parse(readSettings.ReadLine());

                    maxScore = int.Parse(readSettings.ReadLine());
                    currentCicle = int.Parse(readSettings.ReadLine());

                    courses = new string[quantityCourses];
                    
                    for (int course = 0; course < quantityCourses; course++)
                    {
                            courses[course] = readSettings.ReadLine();
                    }
                    
                }


        }



    }

    public class StudentDataRead : ReloadSaveSettings
    {
        public override void ReadSave()
        {
            const string path = @"C:\Users\Mathe_ss6lb0m\Documents\score manager data\StudentData.txt";

            

            using (StreamReader readerStudentData = new StreamReader(path))
            {
                for(int student = 0; student < NumberStudent; student++)
                {
                    StudentNameArray.Add(readerStudentData.ReadLine());
                    allScores.Add(new List<List<Double>> { });
                    for (int course = 0; course  < quantityCourses; course++)
                    {
                        allScores[student].Add(new List<Double> { });
                        for (int cicle = 0; cicle < cicleQuantity; cicle++)
                        {
                            allScores[student][course].Add(Convert.ToDouble(readerStudentData.ReadLine()));
                        }
                    }

                }
            }


        }

    }
}
