using Score_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_Manager.Data
{
    public class SettingsData : ProgramData
    {
        public virtual void Save()
        {

            string path = $@"C:\Users\{Environment.UserName}\Documents\score manager data\settings.txt";
            if (!System.IO.File.Exists(path))
            {
                
                FileStream createFile =  System.IO.File.Create(path);
                createFile.Close();
            }

                using (StreamWriter settingsSave = new StreamWriter(path))
            {

                settingsSave.WriteLine(country);
                settingsSave.WriteLine(quantityCourses);
                settingsSave.WriteLine(NumberStudent);
                settingsSave.WriteLine(cicleQuantity);
                settingsSave.WriteLine($"{maxScore:f2}");
                settingsSave.WriteLine(currentCicle);

                for (int index = 0; index < courses.Length; index++)
                {
                    settingsSave.WriteLine(courses[index]);

                }
            }
        }
    }


    public class StudentData : SettingsData
    {
        public override void Save()
        {
            string path = $@"C:\Users\{Environment.UserName}\Documents\score manager data\StudentData.txt";
            if (!File.Exists(path))
            {
                FileStream createFile = File.Create(path);
                createFile.Close();
            }

            using (StreamWriter listWreater = new StreamWriter(path))
            {
                for (int student = 0; student < StudentNameArray.Count; student++)
                {
                    listWreater.WriteLine(StudentNameArray[student]);

                    for (int course = 0; course < quantityCourses; course++)
                    {
                        foreach (double scores in allScores[student][course])
                        {
                            listWreater.WriteLine($"{scores:f2}");
                        }
                    }
                }
            }
        }
    }
}
