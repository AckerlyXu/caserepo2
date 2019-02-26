<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicAddRow.aspx.cs" Inherits="WebFormCases2.GridViewDemo.DynamicAddRow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound"></asp:GridView>
          <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
  
</body>
</html>
