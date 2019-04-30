<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartAndEmp.aspx.cs" Inherits="WebFormCases2.InsertOneToMany.DepartAndEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="name"></asp:Label><asp:TextBox ID="TextBox1" runat="server">  </asp:TextBox><br />
<asp:Label ID="Label2" runat="server" Text="salary"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        department:<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
    </form>
</body>
</html>
