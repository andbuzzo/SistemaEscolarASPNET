using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cadprofessor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SisEscolar.App_Code.BLL.Professor bllprofessor = new SisEscolar.App_Code.BLL.Professor();
            gdvcadprofessor.DataSource = bllprofessor.SelectInnerJoin();
            gdvcadprofessor.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SisEscolar.App_Code.MODEL.Professor professor = new SisEscolar.App_Code.MODEL.Professor();
        SisEscolar.App_Code.BLL.Professor bllprofessor = new SisEscolar.App_Code.BLL.Professor();
        bool cadastro = false;
        //professor.codigo = Convert.ToInt32(txtcodprofessor.Text);
        professor.descricao = txtnomeprofessor.Text;
  
        cadastro = bllprofessor.Insert(professor, cadastro);
        gdvcadprofessor.DataSource = bllprofessor.SelectInnerJoin();
        gdvcadprofessor.DataBind();

        if (cadastro.Equals(true))
        {
            lblmsg.Text = "CADASTRO REALIZADO COM SUCESSO!";
        }
        else
        {
            lblmsg.Text = "ERRO AO REALIZAR O CADASTRO!";
        }
    }

    protected void btnlimparprofessor_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        txtcodprofessor.Text = "-1";
        txtnomeprofessor.Text = "";
    }
}