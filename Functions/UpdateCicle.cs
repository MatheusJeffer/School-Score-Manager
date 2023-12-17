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
            SettingsData saveData = new SettingsData();

            currentCicle = (cicleQuantity > currentCicle) ? currentCicle++ : currentCicle;
            saveData.Save();
        }

    }
}
