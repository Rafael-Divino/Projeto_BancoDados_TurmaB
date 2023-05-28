using Projeto_BancoDados_TurmaB.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BancoDados_TurmaB
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin objlogin = new frmLogin();
            objlogin.ShowDialog();

            if (objlogin.retorno)
            {
                Application.Run(new frmCadastro());
            }
            
        }
    }
}
