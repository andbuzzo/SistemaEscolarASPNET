<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadcurso.aspx.cs" Inherits="cadcurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 28%;
        }
        .auto-style3 {
            width: 19%;
        }
        .auto-style4 {
            width: 24%;
        }
        .auto-style6 {
            text-align: left;
        }
        .auto-style7 {
            width: 113px;
            text-align: right;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <table align="center" class="auto-style2">
            <tr>
                <td class="auto-style7"><strong>ID:</strong></td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtid" runat="server" ReadOnly="True">-1</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>Descrição:</strong></td>
                <td class="auto-style6">
                    <strong>
                    <asp:TextBox ID="txtcadcurso" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcadcurso" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <strong>Professor</strong></td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="descricao" DataValueField="codigo" Width="126px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">

                    <strong>
                    <asp:Button ID="btncadcurso" runat="server" Text="Cadastrar" CssClass="btn-danger disabled active" style="font-weight: bold; color: #FFFFFF" OnClick="btncadcurso_Click" />
                    </strong>

                </td>
                <td class="auto-style1">

                    <strong>
                    <asp:Button ID="btncadcursolimpar" runat="server" Text="Limpar" CssClass="btn-danger disabled active" style="font-weight: bold; color: #FFFFFF" OnClick="btncadcursolimpar_Click" Width="89px" />
                    </strong>

                </td>
            </tr>
        </table>

        <table align="center" cellpadding="0" cellspacing="0" class="auto-style4">
            <tr>
                <td>
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

        <div style="align-content:center">
            <table align="center" class="auto-style3">
                <tr>
                    <td>
            <asp:GridView ID="GridViewcadcurso" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="363px" AllowPaging="True" AllowSorting="True">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SistemaEscolarConnectionString %>" SelectCommand="SELECT [codigo], [descricao] FROM [Professor]"></asp:SqlDataSource>
    </form>
</body>
</html>
