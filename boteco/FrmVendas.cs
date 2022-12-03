using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace boteco
{
    public partial class FrmVendas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Aluno\source\repos\boteco\DbBoteco.mdf;Integrated Security = True");
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaCbxCliente()
        {
            string cli = "SELECT Id,nome FROM Cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "id";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }

        public void CarregaCbxProduto()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string pro = "SELECT Id,nome FROM Produto";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            CarregaCbxCliente();
            cbxProduto.Enabled = false;
            txtIdProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtTotal.Enabled = false;
            btnAtualizarPedido.Enabled = false;
            btnFinalizarPedido.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnNovoItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("InserirVenda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_pessoa", SqlDbType.NChar).Value = cbxCliente.SelectedValue;
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text);
            cmd.Parameters.AddWithValue("@data_venda", SqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Aberta";
            cmd.ExecuteNonQuery();

            string idvenda = "SELECT IDENT_CURRENT('Venda') AS id_venda";
            SqlCommand cmd2 = new SqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmd2.ExecuteScalar());

            foreach (DataGridViewRow dr in dgvVendas.Rows)
            {
                SqlCommand cmditens = new SqlCommand("InserirItensPedidos", con);
                cmditens.CommandType = CommandType.StoredProcedure;
                cmditens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = idvenda2;
                cmditens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                cmditens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                cmditens.ExecuteNonQuery();
            }
            con.Close();
            dgvVendas.Rows.Clear();
            dgvVendas.Refresh();
            txtTotal.Text = "";
            MessageBox.Show("Pedido realizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            CarregaCbxProduto();
            cbxProduto.Enabled = true;
            txtIdProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtTotal.Enabled = true;
            btnAtualizarPedido.Enabled = true;
            btnFinalizarPedido.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            btnNovoItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            dgvVendas.Columns.Add("ID", " ID");
            dgvVendas.Columns.Add("Produto","Produto");
            dgvVendas.Columns.Add("Valor", "Valor");
            dgvVendas.Columns.Add("Quantidade", "Quantidade");
            dgvVendas.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Produto WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtValor.Text = dr["preco"].ToString();
                txtIdProduto.Text = dr["Id"].ToString();
                txtQuantidade.Focus();
                dr.Close();
                con.Close();
            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Quantidade_Produto", con);
            cmd2.Parameters.AddWithValue("@Id", txtIdProduto.Text);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblEstoque.Text = dr2["quantidade"].ToString();
            }
            dr2.Close();
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            foreach (DataGridViewRow dr in dgvVendas.Rows)
            {
                if (txtIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVendas);
                item.Cells[0].Value = txtIdProduto.Text;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtValor.Text;
                item.Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvVendas.Rows.Add(item);
                txtIdProduto.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                cbxProduto.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvVendas.Rows)
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotal.Text = Convert.ToString(soma);
            }
            else
            {
                MessageBox.Show("Produto já cadastrado no pedido!", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                        
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVendas.CurrentRow.Index;
            dgvVendas.Rows[linha].Cells[0].Value = txtIdProduto.Text;
            dgvVendas.Rows[linha].Cells[1].Value = cbxProduto.Text;
            dgvVendas.Rows[linha].Cells[2].Value = txtQuantidade.Text;
            dgvVendas.Rows[linha].Cells[3].Value = txtValor.Text;
            dgvVendas.Rows[linha].Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);

            cbxProduto.Text = "";
            txtIdProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";

            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVendas.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtTotal.Text = Convert.ToString(soma);
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVendas.CurrentRow.Index;
            dgvVendas.Rows.RemoveAt(linha);
            dgvVendas.Refresh();

            cbxProduto.Text = "";
            txtIdProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";

            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVendas.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtTotal.Text = Convert.ToString(soma);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
