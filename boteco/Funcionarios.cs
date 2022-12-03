using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace boteco
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }
        public string cc { get; set; }
        public string pix { get; set; }
        public string genero { get; set; }
        public string data_nascimento { get; set; }
        public string funcao { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Aluno\source\repos\boteco\DbBoteco.mdf;Integrated Security = True");

        public List<Funcionarios> listafuncionarios()
        {
            List<Funcionarios> li = new List<Funcionarios>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionarios f = new Funcionarios();
                f.Id = (int)dr["Id"];
                f.nome = dr["nome"].ToString();
                f.celular = dr["celular"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.complemento = dr["complemento"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.cep = dr["cep"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.cc = dr["cc"].ToString();
                f.pix = dr["pix"].ToString();
                f.genero = dr["genero"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                f.funcao = dr["funcao"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void Inserir(string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao)
        {
            string sql = "INSERT INTO Funcionario(nome,celular,endereco,complemento,cidade,cep,cpf,cc,pix,genero,data_nascimento,funcao) VALUES ('"+nome+"','"+celular+"','"+endereco+"','"+complemento+"','"+cidade+"','"+cep+"','"+cpf+"','"+cc+"','"+pix+"','"+genero+"','"+data_nascimento+"','"+funcao+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int Id, string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao)
        {
            string sql = "UPDATE Funcionario SET nome='" + nome + "',celular='" + celular + "',endereco='" + endereco + "',complemento='" + complemento + "',cidade='" + cidade + "',cep='" + cep + "',cpf='" + cpf +"',cc='" + cc +"',pix='" + pix +"',genero='" + genero +"',data_nascimento='" + data_nascimento +"',funcao='" + funcao +"' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               nome = dr["nome"].ToString();
               celular = dr["celular"].ToString();
               endereco = dr["endereco"].ToString();
               complemento = dr["complemento"].ToString();
               cidade = dr["cidade"].ToString();
               cep = dr["cep"].ToString();
               cpf = dr["cpf"].ToString();
               cc = dr["cc"].ToString();
               pix = dr["pix"].ToString();
               genero = dr["genero"].ToString();
               data_nascimento = dr["data_nascimento"].ToString();
               funcao  = dr["funcao"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public bool RegistroRepetido(string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao )
        {
            string sql = "SELECT * FROM Funcionario WHERE nome='" + nome + "' AND celular='" + celular + "' AND endereco='" + endereco + "' AND complemento='" + complemento + "' AND cidade='" + cidade + "' AND cep='" + cep + "' AND cpf='" + cpf + "' AND cc='" + cc + "' AND pix='" + pix + "' AND genero='" + genero + "' AND data_nascimento='" + data_nascimento + "' AND funcao='" + funcao + "'";
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
