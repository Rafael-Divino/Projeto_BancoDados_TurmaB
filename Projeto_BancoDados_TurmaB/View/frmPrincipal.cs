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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente objcliente = new frmCliente();
            objcliente.MdiParent = this;
            objcliente.Show();
        }

        private void frmProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto objproduto = new frmProduto();
            objproduto.MdiParent = this;
            objproduto.Show();
        }
    }
}
