<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MaintainScroll.aspx.vb" Inherits="VbCases.MaintainScroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script
  src="http://code.jquery.com/jquery-1.12.4.min.js"
 ></script>
<body>
    <form id="form1" runat="server">
    
        <div style="height:2000px"></div>
        <span>this is bottom</span>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>

</body>
    <script>
        window.onbeforeunload = function () {
            sessionStorage.setItem("wwww.myproject.com.scroll", $(window).scrollTop());
        }
        window.onload = function () {
            var y = sessionStorage.getItem("wwww.myproject.com.scroll");
            if (y) {
                window.scrollTo(0, parseFloat(y));
            }
        }
    </script>
</html>
