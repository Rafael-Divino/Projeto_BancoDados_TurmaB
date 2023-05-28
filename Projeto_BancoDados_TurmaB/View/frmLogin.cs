using Projeto_BancoDados_TurmaB.Controller_DAO;
using Projeto_BancoDados_TurmaB.Model_DTO;
using Projeto_BancoDados_TurmaB.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BancoDados_TurmaB
{
    public partial class frmLogin : Form
    {
        public Boolean retorno = false;

        public DTO_Usuario UsuRetorno = new DTO_Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar a aplicação", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
               // txtSenha.PasswordChar = default;
               txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                //txtSenha.PasswordChar = '*';
                txtSenha.UseSystemPasswordChar = true;
            }
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Usuario usu = new DTO_Usuario();
                usu.Email_usu = txtEmail.Text;
                usu.Senha_usu = txtSenha.Text;

                DAO_Usuario daousuario = new DAO_Usuario();
                UsuRetorno = daousuario.Login(usu);

                if (UsuRetorno.Nome_usu != null)
                {
                    MessageBox.Show("Seja bem vindo Sr(a)" + usu.Nome_usu);
                    retorno = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado! Cadastre-se!");
                }
            }
            catch   (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }
    }
}
