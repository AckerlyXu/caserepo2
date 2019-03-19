<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TriggerClickEventMannually.aspx.cs" Inherits="WebFormCases2.JavascriptDemo.TriggerClickEventMannually" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="Button"  OnClick="Button2_Click" />
          <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
    </form>

</body>
    <script>
        $(function () {
            $("input[type=text]").keyup(function (e) {
               
                if (e.keyCode === 13) {
                    $(this).next(":submit").click();
                }
            })

            $("form").keydown(function (e) {
                if (e.keyCode === 13) {
                    e.preventDefault()
                }
            })
        })
    </script>
</html>
