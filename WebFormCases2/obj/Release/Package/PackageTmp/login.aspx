<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebFormCases2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="username"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="login"  OnClick="Button1_Click"/>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </form>
</body>
</html>
