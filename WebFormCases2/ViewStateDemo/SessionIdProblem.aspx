<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionIdProblem.aspx.cs" Inherits="WebFormCases2.ViewStateDemo.SessionIdProblem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Button ID="btnLogin" runat="server" Text="Button" OnClick="btnLogin_Click" />
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
