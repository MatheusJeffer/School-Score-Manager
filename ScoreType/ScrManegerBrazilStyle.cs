using Score_Manager.Data;
using Score_Manager.InputValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_Manager.ScoreType
{
    public  class ScrManegerBrazilStyle
    {


        public static double ScrBrazil(int arrayVal)
        {
            double score;
            double sumScoreMed = 0;
            double finalScore = 0;

            score = DoubleInputValidator.GetDouble($"Write score of for {ProgramData.courses[arrayVal]} student: ", 10.5, 0);

            return score;
        }

    }
}
