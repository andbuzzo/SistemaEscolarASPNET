using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.BLL
{
    public class Professor
    {
        public List<MODEL.Professor> Select()
        {
            DAL.Professor Professor = new DAL.Professor();

            return Professor.Select();
        }
        public List<MODEL.Professor> SelectInnerJoin()
        {
            DAL.Professor professor = new DAL.Professor();

            return professor.SelectInnerJoin();
        }

        public bool Insert(MODEL.Professor professor, bool cadastro)
        {
            DAL.Professor Professor = new DAL.Professor();
            //
            cadastro= Professor.Insert(professor, cadastro);
            return cadastro;
        }

        public void Update(MODEL.Professor professor)
        {
            DAL.Professor Professor = new DAL.Professor();
            Professor.Update(professor);
        }

        public void Delete(MODEL.Professor professor)
        {
            DAL.Professor Professor = new DAL.Professor();

            Professor.Delete(professor);
        }
    }
}
