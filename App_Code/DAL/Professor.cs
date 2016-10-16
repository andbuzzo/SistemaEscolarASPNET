using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.DAL
{
    public class Professor
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Professor> Select()
        {
            List<MODEL.Professor> lstProfessor = new List<MODEL.Professor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Professor";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Professor Professor = new MODEL.Professor();
                    Professor.codigo = Convert.ToInt32(reader[0].ToString());
                    Professor.descricao = reader["descricao"].ToString();
                    lstProfessor.Add(Professor);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Professores...");
            }
            finally
            {
                conexao.Close();
            }

            return lstProfessor;
        }

        public List<MODEL.Professor> SelectInnerJoin()
        {
            List<MODEL.Professor> lstProfessor = new List<MODEL.Professor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT Curso.codigo, Curso.descricao, Professor.descricao AS Expr1 FROM Curso INNER JOIN Professor ON Curso.professor = Professor.codigo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Professor Professor = new MODEL.Professor();
                    Professor.codigo = Convert.ToInt32(reader[0].ToString());
                    Professor.descricao = reader["descricao"].ToString();
                    lstProfessor.Add(Professor);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Professores...");
            }
            finally
            {
                conexao.Close();
            }

            return lstProfessor;
        }

        public MODEL.Professor SelectById(int codigo)
        {
            MODEL.Professor Professor = new MODEL.Professor();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Professor where codigo=@codigo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    Professor.codigo = Convert.ToInt32(reader[0].ToString());
                    Professor.descricao = reader["descricao"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Professor...");
            }
            finally
            {
                conexao.Close();
            }
            return Professor;
        }

        public bool Insert(MODEL.Professor professor, bool cadastro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Professor values (@descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
           //cmd.Parameters.AddWithValue("@codigo", professor.codigo);
            cmd.Parameters.AddWithValue("@descricao", professor.descricao);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cadastro = true;
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Professores...");
                cadastro = false;
            }
            finally
            {
                conexao.Close();
            }
            return cadastro;
        }

        public void Update(MODEL.Professor Professor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Professor set descricao=@descricao, ";
            sql += " valor=@valor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Professor.codigo);
            cmd.Parameters.AddWithValue("@descricao", Professor.descricao);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Professores");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Professor Professor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Professor where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Professor.codigo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Professor");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
