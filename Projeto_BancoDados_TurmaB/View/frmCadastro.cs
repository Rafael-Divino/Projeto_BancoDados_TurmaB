using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_BancoDados_TurmaB.Controller_DAO;
using Projeto_BancoDados_TurmaB.Model_DTO;

namespace Projeto_BancoDados_TurmaB.View
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Usuario usu = new DTO_Usuario();
                usu.Email_usu = txtEmail.Text;
                usu.Nome_usu = txtNome.Text;
                usu.Senha_usu = txtSenha.Text;

                DAO_Usuario daousu = new DAO_Usuario();
                object retorno = daousu.Inserir(usu);

                if (retorno.ToString() == "1")
                {
                    MessageBox.Show("Cadastro realizado com sucesso!!");
                    Consistencia.LimparForm(this);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
