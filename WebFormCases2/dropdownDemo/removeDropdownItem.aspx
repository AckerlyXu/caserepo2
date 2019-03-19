<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="removeDropdownItem.aspx.cs" Inherits="WebFormCases2.dropdownDemo.removeDropdownItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="table">nottable</asp:ListItem>
            <asp:ListItem Value="not table">table</asp:ListItem>
            <asp:ListItem Value="table">

            </asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" />
    </form>
</body>
</html>
