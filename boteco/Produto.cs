using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace boteco
{
    class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public  string quantidade { get; set; }
        public string preco { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\source\repos\boteco\DbBoteco.mdf;Integrated Security=True");

        public List<Produto> listaproduto()
        {
            List<Produto> li = new List<Produto>();
            string sql = "SELECT * FROM Produto";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto p = new Produto();
                p.Id = (int)dr["Id"];
                p.nome = dr["nome"].ToString();
                p.tipo = dr["tipo"].ToString();
                p.quantidade = dr["quantidade"].ToString();
                p.preco = dr["preco"].ToString();
                li.Add(p);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, string tipo, string quantidade, string preco)
        {
            string sql = "INSERT INTO Produto(nome,tipo,quantidade,preco) VALUES ('" + nome + "','" + tipo + "','" + quantidade + "','" + preco + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Atualizar(int Id, string nome, string tipo, string quantidade, string preco)
        {
            string sql = "UPDATE Cliente SET nome='" + nome + "',cpf='" + tipo + "',data_nascimento='" + quantidade + "',celular='" + preco + "' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Produto WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Produto Where Id = '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                nome = dr["nome"].ToString();
                tipo = dr["tipo"].ToString();
                quantidade = dr["quantidade"].ToString();
                preco = dr["preco"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public bool RegistroRepetido(string nome, string tipo, string quantidade)
        {
            string sql = "SELECT * FROM Produto WHERE nome='" + nome + "' AND tipo='" + tipo + "' AND quantidade='" + quantidade + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
