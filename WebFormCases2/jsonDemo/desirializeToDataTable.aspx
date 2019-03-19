<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="desirializeToDataTable.aspx.cs" Inherits="WebFormCases2.jsonDemo.desirializeToDataTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server">

    </asp:SqlDataSource>
</body>
</html>
