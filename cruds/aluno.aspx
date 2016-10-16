<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aluno.aspx.cs" Inherits="cruds_aluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 24%;
        }
        .auto-style2 {
            width: 77px;
        }
        .auto-style3 {
            width: 344px;
        }
        .auto-style4 {
            width: 18%;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            text-shadow: 0 -1px 0 rgba(0, 0, 0, .2);
            -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, .15), 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: inset 0 1px 0 rgba(255, 255, 255, .15), 0 1px 1px rgba(0, 0, 0, .075);
            filter: progid:DXImageTransform.Microsoft.gradient(enabled=false);
            height: 41px;
            width: 111px;
            border-color: #b92c28;
            background-image: url('linear-gradient(to%20bottom,#d9534f 0,#c12e2a 100%)');
            background-repeat: repeat-x;
            font-weight: bold;
        }
        .auto-style7 {
            width: 77px;
            height: 7px;
        }
        .auto-style8 {
            width: 344px;
            height: 7px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="0" cellspacing="0" class="auto-style1">
            <tr>
                <td class="auto-style2"><strong>Nome:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="301px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <strong>
                    <input id="Submit1" type="submit" value="Pesquisar" class="auto-style6" /></strong></td>
            </tr>
        </table>
        <br />
        <table align="center" class="auto-style4">
            <tr>
                <td class="auto-style5">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="codigo" DataSourceID="SqlDataSource1" Width="550px">
                        <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Código" ReadOnly="True" SortExpression="codigo" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                            <asp:CommandField ButtonType="Button" CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" NewText="Novo" SelectText="Selecionar" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Atualizar" >
                            <ControlStyle CssClass="btn-danger" Font-Bold="True" ForeColor="White" />
                            </asp:CommandField>
                        </Columns>
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SistemaEscolarConnectionString3 %>" DeleteCommand="DELETE FROM [Aluno] WHERE [codigo] = @original_codigo AND (([nome] = @original_nome) OR ([nome] IS NULL AND @original_nome IS NULL))" InsertCommand="INSERT INTO [Aluno] ([codigo], [nome]) VALUES (@codigo, @nome)" SelectCommand="SELECT [codigo], [nome] FROM [Aluno] WHERE ([nome] LIKE '%' + @nome + '%')" UpdateCommand="UPDATE [Aluno] SET [nome] = @nome WHERE [codigo] = @original_codigo AND (([nome] = @original_nome) OR ([nome] IS NULL AND @original_nome IS NULL))" ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
                        <DeleteParameters>
                            <asp:Parameter Name="original_codigo" Type="Int32" />
                            <asp:Parameter Name="original_nome" Type="String" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="codigo" Type="Int32" />
                            <asp:Parameter Name="nome" Type="String" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextBox1" Name="nome" PropertyName="Text" Type="String" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="nome" Type="String" />
                            <asp:Parameter Name="original_codigo" Type="Int32" />
                            <asp:Parameter Name="original_nome" Type="String" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
