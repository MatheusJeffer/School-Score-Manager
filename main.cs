using System;
using Score_Manager.InputValidators;
using Score_Manager.Functions;
using Score_Manager.Data;
using Gerenciador_de_notas_de_alunos.Functions;
using Gerenciador_de_notas_de_alunos.Data;


namespace Score_Manager
{
    public class ProgramMain     {

        public static void Main()
        {
            byte userInput = 0;
            byte cicleInput = 0;
            bool LoopBreaker = true;
            string path = $@"C:\Users\{Environment.UserName}\Documents\score manager data\settings.txt";
            string path1 = $@"C:\Users\{Environment.UserName}\Documents\score manager data\StudentData.txt";

            string pathPaste = $@"C:\Users\{Environment.UserName}\Documents\score manager data";

            ReloadSaveSettings reload = new ReloadSaveSettings();
            StudentDataRead studentDataRead = new StudentDataRead();

            Console.ForegroundColor = ConsoleColor.Blue;

            if (!Directory.Exists(pathPaste))
            {
                Directory.CreateDirectory(pathPaste);
                File.Create(path);
                File.Create(path1);
                PogramConfig.ConfigurationProgram();
            }
            else
            {
                reload.ReadSave();
                studentDataRead.ReadSave();
            }




            do
            {
                Console.WriteLine($"Seja bem vindo: {Environment.UserName}");
                Console.WriteLine("Classroom Score manager:\n [1]Sign in student and score.\n [2]Add score\n" + 
                                             " [3]View all score\n [4]Search Student\n [5]Recofing Program\n [6]Progress the clcle");
                userInput = ByteInputValidator.ByteInput("Select: ", 0, 7);

                switch (userInput)
                {
                    case 1:
                        byte suserInput = ByteInputValidator.ByteInput("Write numbers of students to be regitered: ", 0, 30);
                        StudentSignin.SignIn(suserInput);
                        if (suserInput >= 1)
                        {
                            Console.WriteLine("Student registered!");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Null value.");
                        }

                        break;
                    case 2:
                        AddNewScr.AddNeWScores();
                        break;
                    case 3:
                        ShowStudents.AllStudent();
                        break;
                    case 4:
                        SearchStudent.Search();
                        break;
                    case 5:
                        ResetConfigProgram.resetConfig();
                        break;
                    case 6:
                        UpdateCicle.UpdCicle();
                        Console.WriteLine("Cicle update.");
                        break;
                    default:
                        Console.Write("This option don't exist.");
                        break;

                }

            } while (LoopBreaker);

        
        }

    }

}
