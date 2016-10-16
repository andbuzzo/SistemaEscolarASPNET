<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadprofessor.aspx.cs" Inherits="cadprofessor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 21%;
        }
        .auto-style4 {
            text-align: left;
            width: 93px;
        }
        .auto-style5 {
            text-align: center;
            width: 93px;
        }
        .auto-style6 {
            text-align: left;
        }
        .auto-style7 {
            width: 27%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="auto-style7">
            <tr>
                <td class="auto-style5"><strong>Codigo:</strong></td>
                <td class="auto-style6"><strong>
                    <asp:TextBox ID="txtcodprofessor" runat="server" ReadOnly="True">-1</asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Nome:</strong></td>
                <td class="auto-style6"><strong>
                    <asp:TextBox ID="txtnomeprofessor" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnomeprofessor" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>
                    <asp:Button ID="btncadprofessor" runat="server" CssClass="btn-danger disabled active" OnClick="Button1_Click" style="color: #FFFFFF; font-weight: bold;" Text="Cadastrar" />
                    </strong></td>
                <td class="auto-style2"><strong>
                    <asp:Button ID="btnlimparprofessor" runat="server" CssClass="btn-danger disabled active" style="color: #FFFFFF; font-weight: bold;" Text="Limpar" OnClick="btnlimparprofessor_Click" />
                    </strong></td>
            </tr>
        </table>


    
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style3">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>


    
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style7">
            <tr>
                <td><strong>
                    <asp:GridView ID="gdvcadprofessor" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="395px" AllowPaging="True" AllowSorting="True" AllowCustomPaging="true">
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
                    </strong></td>
            </tr>
        </table>

    
    </div>
    </form>
</body>
</html>
