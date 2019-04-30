<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAuth.aspx.cs" Inherits="WebFormCases2.Services.TestAuth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="login" runat="server" Text="login" OnClick="login_Click" /><asp:Label ID="loginmsg" runat="server" ></asp:Label>
        <br />
        <asp:Button ID="getLoginMsg" runat="server" Text="getLoginMsg" OnClick="getLoginMsg_Click" /> <asp:Label ID="loginMsg2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="logout" OnClick="Button1_Click" />
    </form>
</body>
</html>
