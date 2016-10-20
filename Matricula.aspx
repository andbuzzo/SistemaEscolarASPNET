<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="matricula.aspx.cs" Inherits="contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style15 {
            width: 52%;
            height: 185px;
        }
        .auto-style16 {
            width: 117px;
            text-align: right;
        }
        .auto-style17 {
            width: 23%;
        }
        .auto-style18 {
            width: 117px;
            text-align: right;
            height: 41px;
        }
        .auto-style19 {
            height: 41px;
        }
        .auto-style22 {
            width: 117px;
            text-align: right;
            height: 50px;
        }
        .auto-style23 {
            height: 50px;
        }
        .auto-style24 {
            width: 44%;
        }
        .auto-style25 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="divheader">
        <strong>MATRICULA</strong></div>
    <div>
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style15">
            <tr>
                <td class="auto-style18"><strong>Código:</strong></td>
                <td class="auto-style19">
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="35px" Height="26px">-1</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style22"><strong>Aluno:</strong></td>
                <td class="auto-style23">
                    <asp:DropDownList ID="DropDownaluno" runat="server" Height="35px" Width="240px" DataSourceID="SqlDataSource1" DataTextField="nome" DataValueField="codigo" OnSelectedIndexChanged="DropDownaluno_SelectedIndexChanged">
                       
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SistemaEscolarConnectionString4 %>" SelectCommand="SELECT [codigo], [nome] FROM [Aluno]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style22"><strong>Curso</strong></td>
                <td class="auto-style23">
                    <asp:DropDownList ID="DropDownprofessor" runat="server" Height="35px" Width="240px" DataSourceID="SqlDataSource2" DataTextField="descricao" DataValueField="codigo">
                       </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SistemaEscolarConnectionString3 %>" SelectCommand="SELECT [codigo], [descricao] FROM [Curso]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style16"><strong>Data Matricula:</strong></td>
                <td>
                    <asp:TextBox ID="txtdata" runat="server" Height="26px" Width="141px" OnTextChanged="txtdata_TextChanged" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
        </table>

        <table align="center" cellpadding="0" cellspacing="0" class="auto-style17">
            <tr>
                <td class="auto-style25">
                    <strong>
                    <asp:Button ID="btncadastrar" runat="server" CssClass="btn-danger disabled active" Text="Cadastrar" Height="33px" Width="110px" OnClick="btncadastrar_Click" style="color: #FFFFFF; font-weight: bold;" />
                    </strong>
                </td>
            </tr>
        </table>


        <table align="center" cellpadding="0" cellspacing="0" class="auto-style24">
            <tr>
                <td class="auto-style25">
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True"></asp:Label>
                </td>
            </tr>
        </table>


    </div>
</asp:Content>

