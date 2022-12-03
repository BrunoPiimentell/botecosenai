using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boteco
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbxClientes_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void pbxFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void pbxVendas_Click(object sender, EventArgs e)
        {
            FrmVendas venda = new FrmVendas();
            venda.Show();
        }
    }
}
