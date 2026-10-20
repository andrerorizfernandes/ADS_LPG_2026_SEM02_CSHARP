
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_04.aspx.cs" Inherits="WebBasicos.Exemplo_04" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
            height: 169px;
            position: absolute;
            top: 64px;
            left: 10px;
            z-index: 1;
        }

        .auto-style2 {
            position: absolute;
            top: 56px;
            left: 10px;
            z-index: 1;
        }

        .auto-style3 {
            position: absolute;
            top: 14px;
            left: 10px;
            z-index: 1;
        }

        .auto-style4 {
            position: absolute;
            top: 10px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:RadioButtonList ID="rblFormato" runat="server"
                RepeatDirection="Horizontal"
                CssClass="auto-style4" AutoPostBack="True" OnSelectedIndexChanged="rblFormato_SelectedIndexChanged">
                <asp:ListItem Text="Lista" Value="Lista"></asp:ListItem>
                <asp:ListItem Text="XML" Value="XML"></asp:ListItem>
            </asp:RadioButtonList>

            <asp:Label ID="lblResultado" runat="server"
                CssClass="auto-style3"></asp:Label>

            <asp:DropDownList ID="ddlQuantidade" runat="server"
                AutoPostBack="True"
                CssClass="auto-style2"
                OnSelectedIndexChanged="ddlAlunos_SelectedIndexChanged" Visible="False">
            </asp:DropDownList>

        </div>

        <asp:GridView ID="gvDados" runat="server"
            BackColor="White"
            BorderColor="#CCCCCC"
            BorderStyle="None"
            BorderWidth="1px"
            CellPadding="4"
            ForeColor="Black"
            GridLines="Horizontal"
            CssClass="auto-style1">

            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="Black" HorizontalAlign="Right" BackColor="White" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />

        </asp:GridView>
    </form>
</body>
</html>
