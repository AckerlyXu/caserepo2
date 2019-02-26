<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="openedGridview.aspx.cs" Inherits="WebFormCases2.crossPageDemo.openedGridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" AllowPaging="true" AllowSorting="true" PageSize="3" DataSourceID="SqlDataSource1" >
            <Columns>
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [CompanyName], [CustomerID], [ContactName] FROM [Customers]"></asp:SqlDataSource>
    </form>

    <script>

        window.onload = function () {
            var element = window.parent.getTextbox();
            //select trs  which are not the first or the last
            $("#GridView1 tr:gt(0):not(:last)").each(function (index, ele) {
                $(ele).find("td:eq(1)").css("cursor", "pointer");
            })

             $("#GridView1 tr:gt(0):not(:last)").each(function (index, ele) {
                 $(ele).find("td:eq(1)").click(function () {
                     
                    element.val($(this).html());
                })
                
            })
      
        }
       
    </script>
</body>
</html>
