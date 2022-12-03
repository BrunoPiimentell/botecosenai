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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
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
                Funcionarios funcionarios = new Funcionarios();
                funcionarios.Localizar(Id);
                txtNome.Text = funcionarios.nome;
                txtCPF.Text = funcionarios.cpf;
                txtDN.Text = funcionarios.data_nascimento;
                txtCelular.Text = funcionarios.celular;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" && txtCelular.Text == "" && txtEndereco.Text == "" && txtComplemento.Text == "" && txtCidade.Text == "" && txtCEP.Text == "" && txtCPF.Text == "" && txtCC.Text == "" && txtPix.Text == "" && txtGenero.Text == "" && txtDN.Text == "" && txtFuncao.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o formulário!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNome.Focus();
                }
                else
                {
                    Funcionarios funcionarios = new Funcionarios();
                    if (funcionarios.RegistroRepetido(txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtCC.Text, txtPix.Text, txtGenero.Text, txtDN.Text, txtFuncao.Text) != false)
                    {
                        MessageBox.Show("Este funcionário já existe em nossa base de dados!", "Funcionário Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Text = "";
                        txtCelular.Text = "";
                        txtEndereco.Text = "";
                        txtComplemento.Text = "";
                        txtCidade.Text = "";
                        txtCEP.Text = "";
                        txtCPF.Text = "";
                        txtCC.Text = "";
                        txtPix.Text = "";
                        txtGenero.Text = "";
                        txtDN.Text = "";
                        txtFuncao.Text = "";
                        this.txtNome.Focus();

                    }
                    else
                    {
                        funcionarios.Inserir(txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtCC.Text, txtPix.Text, txtGenero.Text, txtDN.Text, txtFuncao.Text);
                        MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<Funcionarios> funcionario = funcionarios.listafuncionarios();
                        dgvFuncionario.DataSource = funcionario;
                        txtNome.Text = "";
                        txtCelular.Text = "";
                        txtEndereco.Text = "";
                        txtComplemento.Text = "";
                        txtCidade.Text = "";
                        txtCEP.Text = "";
                        txtCPF.Text = "";
                        txtCC.Text = "";
                        txtPix.Text = "";
                        txtGenero.Text = "";
                        txtDN.Text = "";
                        txtFuncao.Text = "";
                        this.txtNome.Focus();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionarios funcionarios = new Funcionarios();
                funcionarios.Atualizar(Id, txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtCC.Text, txtPix.Text, txtGenero.Text, txtDN.Text, txtFuncao.Text);
                MessageBox.Show("Funcionário atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionarios> funcionario = funcionarios.listafuncionarios();
                dgvFuncionario.DataSource = funcionario;
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                txtCidade.Text = "";
                txtCEP.Text = "";
                txtCPF.Text = "";
                txtCC.Text = "";
                txtPix.Text = "";
                txtGenero.Text = "";
                txtDN.Text = "";
                txtFuncao.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
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
                Funcionarios funcionarios = new Funcionarios();
                funcionarios.Excluir(Id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionarios> funcionario = funcionarios.listafuncionarios();
                dgvFuncionario.DataSource = funcionario;
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                txtCidade.Text = "";
                txtCEP.Text = "";
                txtCPF.Text = "";
                txtCC.Text = "";
                txtPix.Text = "";
                txtGenero.Text = "";
                txtDN.Text = "";
                txtFuncao.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            List<Funcionarios> funcionario = funcionarios.listafuncionarios();
            dgvFuncionario.DataSource = funcionario;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                row.Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCelular.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].ToString();
                txtComplemento.Text = row.Cells[4].ToString();
                txtCidade.Text = row.Cells[5].Value.ToString();
                txtCEP.Text = row.Cells[6].Value.ToString();
                txtCPF.Text = row.Cells[7].Value.ToString();
                txtCC.Text = row.Cells[8].Value.ToString();
                txtPix.Text = row.Cells[9].Value.ToString();
                txtGenero.Text = row.Cells[10].Value.ToString();
                txtDN.Text = row.Cells[11].Value.ToString();
                txtFuncao.Text = row.Cells[12].Value.ToString();
            }
        }
    }
}
