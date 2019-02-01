<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="showdatetime.aspx.vb" Inherits="VbCases.showdatetime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="int" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="mydt" HeaderText="mydt" SortExpression="mydt" />
         
                <asp:BoundField DataField="int" HeaderText="int" InsertVisible="False" ReadOnly="True" SortExpression="int" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EntityExeConnectionString %>" SelectCommand="SELECT [mydt], [int] FROM [mydatetime]"></asp:SqlDataSource>
    </form>
</body>
</html>
