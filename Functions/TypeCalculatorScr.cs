using Gerenciador_de_notas_de_alunos.ScoreType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.Functions
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
