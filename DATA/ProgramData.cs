using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.DATA
{
    public class ProgramData
    {
        public static List<List<List<double>>> allScores = new List<List<List<double>>> { };
        public static List<string> StudentNameArray = new List<string> { };
        public static double StudentScoreSum = 0;
        public static int NumberStudent = 0;
        public static int StudentRegister = 0;
        public static string[] courses = [];
        public static int quantityCourses;
        public static string country = "Brazil";
        public static int cicleQuantity;
    }
}
