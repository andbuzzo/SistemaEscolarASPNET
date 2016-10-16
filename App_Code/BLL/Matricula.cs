using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.BLL
{
    public class Matricula
    {
        public List<MODEL.Matricula> Select()
        {
            DAL.Matricula dalMatricula = new DAL.Matricula();
            return dalMatricula.Select();
        }

        public bool Insert(MODEL.Matricula matricula, bool cadastro)
        {
            DAL.Matricula dalMatricula = new DAL.Matricula();
            //
            cadastro = dalMatricula.Insert(matricula, cadastro);
            return cadastro;
        }

        public void Update(MODEL.Matricula Matricula)
        {
            DAL.Matricula dalMatricula = new DAL.Matricula();
            dalMatricula.Update(Matricula);
        }

        public void Delete(MODEL.Matricula Matricula)
        {
            DAL.Matricula dalMatricula = new DAL.Matricula();

            dalMatricula.Delete(Matricula);
        }
    }
}
