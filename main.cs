using System;
using Gerenciador_de_notas_de_alunos.InputValidators;
using Gerenciador_de_notas_de_alunos.Functions;
using Gerenciador_de_notas_de_alunos.DATA;


namespace Gerenciador_de_notas_de_alunos
{
    public class ProgramMain     {

        public static void Main()
        {
            byte userInput = 0;
            bool LoopBreaker = true;

            PogramConfig.ConfigurationProgram();

            do
            {
                Console.WriteLine("Classroom Score manager:\n [1]Sign in student and score.\n [2]Classroom final score.\n" + 
                                             " [3]All score\n [4]Search Student\n [5]Recofing Program\n [6]Quit");
                userInput = ByteInputValidator.ByteInput("Select: ");

                switch (userInput)
                {
                    case 1:
                        byte suserInput = ByteInputValidator.ByteInput("Write numbers of students to be regitered: ");
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

                        userInput = ByteInputValidator.ByteInput("Select:");
                        ResetConfigProgram.resetConfig(userInput);
                        break;
                    case 6:
                        LoopBreaker = false;
                        break;
                    default:
                        Console.Write("This option don't exist.");
                        break;

                }

            } while (LoopBreaker);

        
        }

    }

}
