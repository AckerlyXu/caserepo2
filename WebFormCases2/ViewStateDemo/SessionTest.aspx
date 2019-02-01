<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionTest.aspx.cs" Inherits="WebFormCases2.ViewStateDemo.SessionTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/ViewStateDemo/second.aspx">go to second page</asp:LinkButton>
    </form>
</body>
</html>
