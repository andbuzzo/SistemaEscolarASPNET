using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.BLL
{
    public class Aluno
    {
        public List<MODEL.Aluno> Select()
        {
            DAL.Aluno Aluno = new DAL.Aluno();

            return Aluno.Select();
        }

        public bool Insert(MODEL.Aluno aluno, bool cadastro)
        {
            DAL.Aluno Aluno = new DAL.Aluno();
            //
            cadastro = Aluno.Insert(aluno, cadastro);
            return cadastro;
        }

        public void Update(MODEL.Aluno aluno)
        {
            DAL.Aluno Aluno = new DAL.Aluno();
            Aluno.Update(aluno);
        }

        public void Delete(MODEL.Aluno aluno)
        {
            DAL.Aluno Aluno = new DAL.Aluno();

            Aluno.Delete(aluno);
        }
    }
}
