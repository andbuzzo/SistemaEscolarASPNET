using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.BLL
{
    public class Curso
    {
        public List<MODEL.Curso> Select()
        {
            DAL.Curso dalCli = new DAL.Curso();

            return dalCli.Select();
        }

        public List<MODEL.Curso> SelectInnerJoin()
        {
            DAL.Curso dalCli = new DAL.Curso();

            return dalCli.Select();
        }

        public List<MODEL.Curso> SelectById(int codigo)
        {
            DAL.Curso dalCli = new DAL.Curso();

            return dalCli.SelectById(codigo);
        }

        public List<MODEL.Curso> SelectByNome(string descricao)
        {
            DAL.Curso dalCli = new DAL.Curso();

            return dalCli.SelectByNome(descricao);
        }

        public bool Insert(MODEL.Curso Curso, bool cadastro)
        {
            DAL.Curso dalCli = new DAL.Curso();
            //
            cadastro = dalCli.Insert(Curso, cadastro);
            return cadastro;
        }

        public void Update(MODEL.Curso Curso)
        {
            DAL.Curso dalCli = new DAL.Curso();
            dalCli.Update(Curso); 
        }

        public void Delete (MODEL.Curso Curso)
        {
            DAL.Curso dalCli = new DAL.Curso();

            dalCli.Delete(Curso);
        }
    }
}
