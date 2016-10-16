using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.DAL
{
    public class Aluno
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Aluno> Select()
        {
            List<MODEL.Aluno> lstAluno = new List<MODEL.Aluno>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluno";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Aluno Aluno = new MODEL.Aluno();
                    Aluno.codigo = Convert.ToInt32(reader[0].ToString());
                    Aluno.nome = reader["nome"].ToString();
                    lstAluno.Add(Aluno);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Alunos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstAluno;
        }

        public MODEL.Aluno SelectById(int codigo)
        {
            MODEL.Aluno Aluno = new MODEL.Aluno();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Aluno where codigo=@codigo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    Aluno.codigo = Convert.ToInt32(reader[0].ToString());
                    Aluno.nome = reader["nome"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Alunos...");
            }
            finally
            {
                conexao.Close();
            }
            return Aluno;
        }

        public bool Insert(MODEL.Aluno Aluno, bool cadastro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Aluno values (@nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            //cmd.Parameters.AddWithValue("@codigo", Aluno.codigo);
            cmd.Parameters.AddWithValue("@nome", Aluno.nome);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cadastro = true;
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Alunos...");
                cadastro = false;
            }
            finally
            {
                conexao.Close();
            }
            return cadastro;
        }

        public void Update(MODEL.Aluno Aluno)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Aluno set descricao=@descricao, ";
            sql += "where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Aluno.codigo);
            cmd.Parameters.AddWithValue("@titulo", Aluno.nome);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Alunos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Aluno Aluno)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Aluno where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Aluno.codigo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Alunos");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
