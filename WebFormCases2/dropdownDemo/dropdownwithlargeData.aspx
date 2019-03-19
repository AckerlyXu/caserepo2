<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdownwithlargeData.aspx.cs" Inherits="WebFormCases2.dropdownDemo.dropdownwithlargeData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </form>
</body>
</html>
