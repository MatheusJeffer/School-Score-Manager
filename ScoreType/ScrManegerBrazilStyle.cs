using Gerenciador_de_notas_de_alunos.DATA;
using Gerenciador_de_notas_de_alunos.InputValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.ScoreType
{
    public  class ScrManegerBrazilStyle
    {


        public static double ScrBrazil(int arrayVal)
        {
            double score;
            double sumScoreMed = 0;
            double finalScore = 0;

                   score = DoubleInputValidator.GetDouble($"Write score of for {ProgramData.courses[arrayVal]} student: ", 10.5,   0);

            return score;
        }

    }
}
