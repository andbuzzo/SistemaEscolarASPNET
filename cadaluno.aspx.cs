using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cadaluno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SisEscolar.App_Code.BLL.Aluno bllaluno = new SisEscolar.App_Code.BLL.Aluno();
            gdvaluno.DataSource = bllaluno.Select();
            gdvaluno.DataBind();
        }
    }

    protected void btncadaluno_Click(object sender, EventArgs e)
    {
        SisEscolar.App_Code.MODEL.Aluno aluno = new SisEscolar.App_Code.MODEL.Aluno();
        SisEscolar.App_Code.BLL.Aluno bllaluno = new SisEscolar.App_Code.BLL.Aluno();
        bool cadastro = false;
        //aluno.codigo = Convert.ToInt32(txtcodigoaluno.Text);
        aluno.nome = txtnomealuno.Text;

        cadastro = bllaluno.Insert(aluno, cadastro);
        gdvaluno.DataSource = bllaluno.Select();
        gdvaluno.DataBind();

        if (cadastro.Equals(true))
        {
            lblmsg.Text = "CADASTRO REALIZADO COM SUCESSO!";
        }
        else
        {
            lblmsg.Text = "ERRO AO REALIZAR O CADASTRO!";
        }

    }

    protected void btnlimparaluno_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        txtcodigoaluno.Text = "-1";
        txtnomealuno.Text = "";
    }
}