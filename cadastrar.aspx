<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cadastrar.aspx.cs" Inherits="cadastrar" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style13 {
            width: 67%;
            background-color: #B23D3A;
            height: 23px;
        }
        .auto-style16 {
            text-shadow: 0 -1px 0 rgba(0, 0, 0, .2);
            -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, .15), 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: inset 0 1px 0 rgba(255, 255, 255, .15), 0 1px 1px rgba(0, 0, 0, .075);
            filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
            text-decoration: none;
            border-color: #3e8f3e;
            background-image: url('linear-gradient(to%20bottom,%20#5cb85c 0%, #419641 100%)');
            background-repeat: repeat-x;
        }
        .auto-style17 {
            background-color: #C12E2A;
            color: #FEFFFF;
        }
        .auto-style18 {
            width: 100%;
            height: 604px;
            s
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="divheader">
        <strong>CADASTROS</strong></div>
   <div>
       <table align="center" cellpadding="0" cellspacing="0" class="auto-style13">
           <tr>
               <td class="div">
                    <a href="cadcurso.aspx" target="IframeCad" class="auto-style16"><span class="auto-style17"><strong><em>Curso</em></strong></span></a></td>
               <td class="div">
                   <a href="cadprofessor.aspx" target="IframeCad" class="auto-style16"><span class="auto-style17"><strong><em>Professor</em></strong></span></a></td>
               <td class="div">
                    <a href="cadaluno.aspx" target="IframeCad" class="auto-style16"><span class="auto-style17"><strong><em>Aluno</em></strong></span></a></td>
           </tr>
       </table>
    </div>
   <div></div>
    <div></div>
   <div><iframe name="IframeCad" style="border-style: none; border-color: inherit; border-width: medium; display:block; " class="auto-style18"></iframe></div>

</asp:Content>

