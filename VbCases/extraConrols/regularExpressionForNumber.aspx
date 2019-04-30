<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regularExpressionForNumber.aspx.vb" Inherits="VbCases.regularExpressionForNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
 
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="only allow number" ControlToValidate="TextBox1" ValidationExpression="[1,9]\d*"></asp:RegularExpressionValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />

         <asp:TextBox ID="TextBox2" runat="server" Text="" TextMode="MultiLine" Width="400" Height="400" CssClass="text"></asp:TextBox>
    </form>
</body>
</html>
