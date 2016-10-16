using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscolar.App_Code.MODEL
{
    public class Matricula
    {
        public int codigo { get; set; }
        public int codigoAluno { get; set; }
        public int codigoCurso { get; set; }
        public DateTime DataMatricula { get; set; }
    }
}
