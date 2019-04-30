<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MergeCellsOnlyForTheFirstColumn.aspx.cs" Inherits="WebFormCases2.GridViewDemo.MergeCellsOnlyForTheFirstColumn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="StdGrid" runat="server" OnDataBound="StdGrid_DataBound"  ></asp:GridView>
    </form>
</body>
</html>
