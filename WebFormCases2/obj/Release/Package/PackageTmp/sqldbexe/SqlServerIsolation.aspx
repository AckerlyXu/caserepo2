<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlServerIsolation.aspx.cs" Inherits="WebFormCases2.sqldbexe.SqlServerIsolation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    </form>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EntityDb %>" SelectCommand="SELECT [id], [name], [age] FROM [student]"></asp:SqlDataSource>
</body>
</html>
