using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.DAL
{
    public class Curso
    {
        private string strCon = Conexao.getConexao(); 

        public List<MODEL.Curso> Select()
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Curso";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.codigo = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["descricao"].ToString();
                    Curso.professor = Convert.ToInt32(reader["professor"].ToString());
                    lstCurso.Add(Curso);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cursos...");
            }
            finally
            {
                conexao.Close();     
            }
            
            return lstCurso; 
        }

        public List<MODEL.Curso> SelectInnerJoin()
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT Curso.codigo, Curso.descricao, Professor.descricao AS Expr1 FROM Curso INNER JOIN Professor ON Curso.professor = Professor.codigo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.codigo = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["Curso.descricao"].ToString();
                    Curso.professor = Convert.ToInt32(reader["Professor.descricao"].ToString());
                    lstCurso.Add(Curso);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cursos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCurso;
        }

        public List<MODEL.Curso> SelectById(int codigo)
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Curso where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo); 
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.codigo = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["descricao"].ToString();
                    Curso.professor = Convert.ToInt32(reader["professor"].ToString());
                    lstCurso.Add(Curso);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cursos por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCurso;
        }


        public List<MODEL.Curso> SelectByNome(string descricao)
        {
            List<MODEL.Curso> lstCurso = new List<MODEL.Curso>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Curso where (descricao like @descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", descricao.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Curso Curso = new MODEL.Curso();
                    Curso.codigo = Convert.ToInt32(reader[0].ToString());
                    Curso.descricao = reader["descricao"].ToString();
                    Curso.professor = Convert.ToInt32(reader["professor"].ToString());
                    lstCurso.Add(Curso);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Cursos por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCurso;
        }

        public bool Insert (MODEL.Curso Curso, bool cadastro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Curso values (@descricao, @professor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", Curso.descricao);
            cmd.Parameters.AddWithValue("@professor", Curso.professor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cadastro = true;
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Cursos...");
                cadastro = false;
            }
            finally
            {
                conexao.Close();
            }
            return cadastro;
        }

        public void Update(MODEL.Curso Curso)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cursos set descricao=@descricao, ";
            sql += " professor=@professor";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Curso.codigo); 
            cmd.Parameters.AddWithValue("@descricao", Curso.descricao);
            cmd.Parameters.AddWithValue("@professor", Curso.professor);
            conexao.Open(); 
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Cursos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Curso Curso) {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cursos where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Curso.codigo);     
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Cursos");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}




