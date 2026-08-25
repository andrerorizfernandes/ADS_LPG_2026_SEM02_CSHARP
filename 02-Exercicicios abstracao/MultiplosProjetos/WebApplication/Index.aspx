<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Cadastro de Professor</title>
        <link href="Content/Site.css" rel="stylesheet" type="text/css" />
    </head>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <h2>Cadastro de Professor</h2>
                <div class="campo">
                    <asp:Label
                        ID="lblNome"
                        runat="server"
                        Text="Nome:">
                    </asp:Label>
                    <asp:TextBox
                        ID="txtNome"
                        runat="server">
                    </asp:TextBox>
                </div>
                <div class="campo">
                    <asp:Label
                        ID="lblDisciplina"
                        runat="server"
                        Text="Disciplina:">
                    </asp:Label>
                    <asp:TextBox
                        ID="txtDisciplina"
                        runat="server">
                    </asp:TextBox>
                </div>
                <div class="campo">
                    <asp:Label
                        ID="lblCargaHoraria"
                        runat="server"
                        Text="Carga Horária:">
                    </asp:Label>
                    <asp:TextBox
                        ID="txtCargaHoraria"
                        runat="server"
                        TextMode="Number">
                    </asp:TextBox>
                </div>
                <asp:Button
                    ID="btnCadastrar"
                    runat="server"
                    Text="Cadastrar"
                    CssClass="botao"
                    OnClick="ButtonCadastrar_Click" />
                <div class="resultado">
                    <h3>Dados cadastrados</h3>
                    <asp:Label
                        ID="lblResultado"
                        runat="server"
                        Text="Nenhum professor cadastrado.">
                    </asp:Label>
                </div>
            </div>
        </form>
    </body>
</html>