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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor digite um ID!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
            else
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Produto produto = new Produto();
                produto.Localizar(Id);
                txtNome.Text = produto.nome;
                txtTipo.Text = produto.tipo;
                txtQuantidade.Text = produto.quantidade;
                txtPreco.Text = produto.preco;
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            List<Produto> produtos = produto.listaproduto();
            dgvProduto.DataSource = produtos;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" && txtTipo.Text == "" && txtQuantidade.Text == "" && txtPreco.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o formulário!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNome.Focus();
                }
                else
                {
                    Produto produto = new Produto();
                    if (produto.RegistroRepetido(txtNome.Text, txtTipo.Text, txtQuantidade.Text) != false)
                    {
                        MessageBox.Show("Este produto já existe em nossa base de dados!", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Text = "";
                        txtTipo.Text = "";
                        txtQuantidade.Text = "";
                        txtPreco.Text = "";
                        this.txtNome.Focus();

                    }
                    else
                    {
                        produto.Inserir(txtNome.Text, txtTipo.Text, txtQuantidade.Text, txtPreco.Text);
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<Produto> produtos = produto.listaproduto();
                        dgvProduto.DataSource = produtos;
                        txtNome.Text = "";
                        txtTipo.Text = "";
                        txtQuantidade.Text = "";
                        txtPreco.Text = "";
                        this.txtNome.Focus();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Produto produto = new Produto();
                produto.Atualizar(Id, txtNome.Text, txtTipo.Text, txtQuantidade.Text, txtPreco.Text);
                MessageBox.Show("Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produtos = produto.listaproduto();
                dgvProduto.DataSource = produtos;
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
                this.txtNome.Focus();
                btnAtualizar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Produto produto = new Produto();
                produto.Excluir(Id);
                MessageBox.Show("Produto excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produtos = produto.listaproduto();
                dgvProduto.DataSource = produtos;
                txtNome.Text = "";
                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
                this.txtNome.Focus();
                btnAtualizar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                row.Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtTipo.Text = row.Cells[2].Value.ToString();
                txtQuantidade.Text = row.Cells[3].ToString();
                txtPreco.Text = row.Cells[4].ToString();
            }
        }
    }
}
