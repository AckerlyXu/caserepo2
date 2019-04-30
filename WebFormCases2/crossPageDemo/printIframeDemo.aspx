<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="printIframeDemo.aspx.cs" Inherits="WebFormCases2.crossPageDemo.printIframeDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <iframe src="../Default.aspx" id="myframe" height="200" name="abc"></iframe>
    </form>
    <input id="Button1" type="button" value="pring iframe" />
</body>
    <script>
        window.onload = function () {
            document.getElementById("Button1").onclick = function () {
                anotherwindow = window.open(document.getElementById("myframe").src,"abc");
                
                anotherwindow.onafterprint = function () {
                    anotherwindow.close();
                }
                anotherwindow.print();
               // document.getElementById("myframe").contentWindow.focus()
               // document.getElementById("myframe").contentWindow.print();
            }   
        }
    </script>
</html>
