using Score_Manager.ScoreType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_Manager.Functions
{
    public static class TypeCalculatorScr
    {
        public static double TypeScr(string typeScore, int courseQuantitys)
        {

            double totalScore = 0;

            switch (typeScore)
            {
                case "Brazil":
                   totalScore = ScrManegerBrazilStyle.ScrBrazil(courseQuantitys);
                    break;
            }
            return totalScore;
        }




    }
}
