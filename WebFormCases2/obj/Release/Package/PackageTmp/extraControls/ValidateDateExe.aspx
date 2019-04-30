<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidateDateExe.aspx.cs" Inherits="WebFormCases2.extraControls.ValidateDateExe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"  ></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage=" the value should only be Mondays"
            ClientValidationFunction="validateMonday" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="TextBox1"
            >


        </asp:CustomValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
    <script>
  
        function validateMonday(a, b, c) {
            var date = new Date(b.Value.replace(/-/g, "/"));
           
            if (date.getDay() != 1) {
               b.IsValid = false;
            }  
            return b;
            
        }

    </script>
</body>
</html>
