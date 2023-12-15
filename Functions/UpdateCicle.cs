using Score_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_notas_de_alunos.Functions
{
    public class UpdateCicle :  ProgramData
    {
        public static void UpdCicle()
        {
            currentCicle = (currentCicle < cicleQuantity) ? currentCicle += 1 : currentCicle;
        }

    }
}
