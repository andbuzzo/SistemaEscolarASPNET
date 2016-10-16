using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.DAL
{
    public class Matricula
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Matricula> Select()
        {
            List<MODEL.Matricula> lstMatricula = new List<MODEL.Matricula>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Matricula";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Matricula Matricula = new MODEL.Matricula();
                    Matricula.codigo = Convert.ToInt32(reader[0].ToString());
                    Matricula.codigoAluno = Convert.ToInt32(reader["codigoAluno"].ToString());
                    Matricula.codigoCurso = Convert.ToInt32(reader["codigoCurso"].ToString());
                    Matricula.DataMatricula = Convert.ToDateTime(reader["DataMatricula"].ToString());

                    lstMatricula.Add(Matricula);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Seleção de Matricula...");
            }
            finally
            {
                conexao.Close();
            }

            return lstMatricula;
        }

        public bool Insert(MODEL.Matricula Matricula, bool cadastro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Matricula values (@codigoAluno, @codigoCurso, @DataMatricula);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigoAluno", Matricula.codigoAluno);
            cmd.Parameters.AddWithValue("@codigoCurso", Matricula.codigoCurso);
            cmd.Parameters.AddWithValue("@DataMatricula", Matricula.DataMatricula);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cadastro = true;
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Matricula...");
                cadastro = false;
            }
            finally
            {
                conexao.Close();
            }
            return cadastro;
        }

        public void Update(MODEL.Matricula Matricula)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Matricula set codigoAluno=@codigoAluno, ";
            sql += " codigoCurso=@codigoCurso, DataMatricula=@DataMatricula where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Matricula.codigo);
            cmd.Parameters.AddWithValue("@codigoAluno", Matricula.codigoAluno);
            cmd.Parameters.AddWithValue("@codigoCurso", Matricula.codigoCurso);
            cmd.Parameters.AddWithValue("@DataMatricula", Matricula.DataMatricula);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Matricula");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Matricula Matricula)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Matricula where codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", Matricula.codigo);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Remoção de Matricula");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}
