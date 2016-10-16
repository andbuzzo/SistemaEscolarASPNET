<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadaluno.aspx.cs" Inherits="cadaluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 27%;
            height: 12px;
        }
        .auto-style2 {
            width: 175px;
            text-align: center;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            width: 18%;
        }
        .auto-style6 {
            width: 40%;
        }
        .auto-style7 {
            width: 13%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style6">
            <tr>
                <td class="auto-style2"><strong>Código:</strong></td>
                <td class="auto-style4"><strong>
                    <asp:TextBox ID="txtcodigoaluno" runat="server" Width="53px" ReadOnly="True">-1</asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Nome:</strong></td>
                <td class="auto-style4"><strong>
                    <asp:TextBox ID="txtnomealuno" runat="server" Width="254px" Height="20px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnomealuno" ErrorMessage="RequiredFieldValidator">Digite um Nome</asp:RequiredFieldValidator>
                    </strong></td>
                </tr>
            </table>



    
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style7">
            <tr>
                <td><strong>
                    <asp:Button ID="btncadaluno" runat="server" CssClass="btn-danger disabled active" style="font-weight: bold; color: #FFFFFF" Text="Cadastrar" OnClick="btncadaluno_Click" />
                    </strong></td>
                <td><strong>
                    <asp:Button ID="btnlimparaluno" runat="server" CssClass="btn-danger disabled active" style="font-weight: bold; color: #FFFFFF" Text="Limpar" OnClick="btnlimparaluno_Click" Width="91px" />
                    </strong></td>
            </tr>
        </table>



    
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <br />
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>


    
        <table align="center" class="auto-style5">
            <tr>
                <td><strong>
                    <asp:GridView ID="gdvaluno" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="370px" AllowPaging="True" AllowSorting="True">
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
