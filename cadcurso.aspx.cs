using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cadcurso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SisEscolar.App_Code.BLL.Curso bllCurso = new SisEscolar.App_Code.BLL.Curso();
            GridViewcadcurso.DataSource = bllCurso.SelectInnerJoin();
            GridViewcadcurso.DataBind();
        }

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void btncadcurso_Click(object sender, EventArgs e)
    {
        SisEscolar.App_Code.MODEL.Curso curso = new SisEscolar.App_Code.MODEL.Curso();
        SisEscolar.App_Code.BLL.Curso bllcurso = new SisEscolar.App_Code.BLL.Curso();
        bool cadastro = false;
        //curso.codigo = Convert.ToInt32(txtid.Text);
        curso.descricao = txtcadcurso.Text;
        curso.professor = Convert.ToInt32(DropDownList1.SelectedItem.Value);

        cadastro = bllcurso.Insert(curso, cadastro);
        GridViewcadcurso.DataSource = bllcurso.SelectInnerJoin();
        GridViewcadcurso.DataBind();

        if (cadastro.Equals(true))
        {
            lblmsg.Text = "CADASTRO REALIZADO COM SUCESSO!";
        }
        else
        {
            lblmsg.Text = "ERRO AO REALIZAR O CADASTRO!";
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btncadcursolimpar_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        txtcadcurso.Text = "";
        txtid.Text = "-1";
    }
}