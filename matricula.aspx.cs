using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtdata.Text = DateTime.Now.ToString();
    }


    protected void txtdata_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btncadastrar_Click(object sender, EventArgs e)
    {
        SisEscolar.App_Code.MODEL.Matricula matricula = new SisEscolar.App_Code.MODEL.Matricula();
        SisEscolar.App_Code.BLL.Matricula bllmatricula = new SisEscolar.App_Code.BLL.Matricula();
        bool cadastro = false;
        //professor.codigo = Convert.ToInt32(txtcodprofessor.Text);
        matricula.codigoAluno = Convert.ToInt32(DropDownaluno.SelectedItem.Value);
        matricula.codigoCurso = Convert.ToInt32(DropDownprofessor.SelectedItem.Value);
        matricula.DataMatricula = Convert.ToDateTime(txtdata.Text);

        cadastro = bllmatricula.Insert(matricula, cadastro);

        if (cadastro.Equals(true))
        {
            lblmsg.Text = "MATRICULA REALIZADA COM SUCESSO!";
        }
        else
        {
            lblmsg.Text = "ERRO AO REALIZAR A MATRICULA!";
        }
    }

    protected void DropDownaluno_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}