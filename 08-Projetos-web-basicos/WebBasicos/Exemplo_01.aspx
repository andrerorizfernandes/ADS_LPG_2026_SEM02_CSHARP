<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_01.aspx.cs" Inherits="WebBasicos.Exemplo_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">    
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 11px;
            top: 76px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 13px;
            top: 14px;
            position: absolute;
            width: 361px;
        }
        .auto-style3 {
            z-index: 1;
            left: 12px;
            top: 46px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style4">
            
        <asp:Label ID="lblInformacao" runat="server" BackColor="#FFFF99" Font-Bold="True" ForeColor="Red" CssClass="auto-style3"></asp:Label>
        <asp:Button ID="btnProcessar" runat="server" OnClick="btnProcessar_Click" Text="Processar" CssClass="auto-style1"/>
    </div>
        <asp:TextBox ID="txtEntradaDados" runat="server" CssClass="auto-style2"></asp:TextBox>
    </form>
</body>
</html>