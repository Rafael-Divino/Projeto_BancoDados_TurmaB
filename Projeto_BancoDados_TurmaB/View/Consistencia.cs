using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BancoDados_TurmaB.View
{
    public class Consistencia
    {
        #region Método para limpar formulario

        public static void LimparForm (Form formlimpar)
        {
            foreach (Control item in formlimpar.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        #endregion

    }
}
