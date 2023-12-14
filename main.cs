using System;
using Score_Manager.InputValidators;
using Score_Manager.Functions;
using Score_Manager.Data;


namespace Score_Manager
{
    public class ProgramMain     {

        public static void Main()
        {
            byte userInput = 0;
            byte cicleInput = 0;
            bool LoopBreaker = true;

            PogramConfig.ConfigurationProgram();

            do
            {
                Console.WriteLine("Classroom Score manager:\n [1]Sign in student and score.\n [2]Classroom final score.\n" + 
                                             " [3]All score\n [4]Search Student\n [5]Recofing Program\n [6]Add scores");
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
                        Console.WriteLine($"The score of classroom is {ProgramData.StudentScoreSum:f2}, " +
                            $"but the avarage final is: {ProgramData.StudentScoreSum / ProgramData.NumberStudent:f2}");
                        break;
                    case 3:
                        ShowStudents.AllStudent();
                        break;
                    case 4:
                        SearchStudent.Search();
                        break;
                    case 5:
                        Console.WriteLine("Choose configuration for reset:\n [1]Reset course quantity and add more courses.\n" +
                                          " [2]Reset cicles quantity\n [3]Reset country\n");

                        userInput = ByteInputValidator.ByteInput("Select:", 0, 3);
                        ResetConfigProgram.resetConfig(userInput);
                        break;
                    case 6:
                        cicleInput = ByteInputValidator.ByteInput("Write number of cicle: ", 0, ProgramData.cicleQuantity);

                        AddNewScr.AddNeWScores(cicleInput);
                        break;
                    default:
                        Console.Write("This option don't exist.");
                        break;

                }

            } while (LoopBreaker);

        
        }

    }

}
