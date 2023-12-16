using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.UI;

namespace Score_Manager.Data
{
    /// <summary>
    ///  A classe <see cref="ProgramData"/> é responsável por conter todos os dados do programa, sendo essencial para 
    ///  todo o funcionamento do programa.
    /// </summary>
   
    public class ProgramData
    {
        public static List<List<List<double>>> allScores = new List<List<List<double>>> { };
        public static List<string> StudentNameArray = new List<string> { };
        public static int NumberStudent = 0;
        public static int studantQuantity = 0;
        public static int currentCicle = 0;
        public static double maxScore = 0;
        public static int StudentRegister = 0;
        public static string[] courses = [];
        public static int quantityCourses;
        public static string country = "Brazil";
        public static int cicleQuantity;
    }
}
