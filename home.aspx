<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style13 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="divheader"><strong>CURSOS DISPONIVEIS</strong></div>
    <div>

        <table align="center" cellpadding="0" cellspacing="0" class="auto-style6">
            <tr>
                <td>
                    <br />
                    <div class="auto-style13">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="codigo" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Width="455px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CCCCCC" HorizontalAlign="Center" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Código" ReadOnly="True" SortExpression="codigo" />
                <asp:BoundField DataField="descricao" HeaderText="Curso" SortExpression="descricao" />
                <asp:BoundField DataField="Expr1" HeaderText="Professor" SortExpression="Expr1" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="#B23D3A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SistemaEscolarConnectionString %>" SelectCommand="SELECT Curso.codigo, Curso.descricao, Professor.descricao AS Expr1 FROM Curso INNER JOIN Professor ON Curso.professor = Professor.codigo"></asp:SqlDataSource>
    </div>
</asp:Content>

