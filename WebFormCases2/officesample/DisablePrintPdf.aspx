<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisablePrintPdf.aspx.cs" Inherits="WebFormCases2.officesample.DisablePrintPdf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        
        <iframe  id="ifa" width="1000" height="500" src="abc.pdf"  ></iframe>
        
    </form>

    <script type="text/javascript">
    
      $win = document.getElementById("ifa").contentWindow
        $win.onbeforeprint = function () {
            $('<div style="background-color:black;position:absolute;z-index:100;height:1000px;width:500px;top:0"></div>').appendTo($(this).find("body"));
              }
             
             


               window.onbeforeprint = function () {
                 $('<div style="background-color:black;position:absolute;z-index:100;height:1000px;width:500px;top:0"></div>').appendTo($("body"))
              }
    </script>
</body>
</html>
