<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicWhereCaluse.aspx.cs" Inherits="WebFormCases2.sqldbexe.DynamicWhereCaluse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem Text="A" Value="A"></asp:ListItem>
    <asp:ListItem Text="B" Value="B"></asp:ListItem>
    <asp:ListItem Text="C" Value="C"></asp:ListItem>
    <asp:ListItem Text="D" Value="D"></asp:ListItem>

        </asp:CheckBoxList>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
