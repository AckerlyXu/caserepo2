<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FullScreenBackgroundImage.aspx.cs" Inherits="WebFormCases2.cssDemo.FullScreenBackgroundImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #banner {
background-image: url("/images/WingtipToys/boatbig.png");
background-position: center;
background-size: cover;
background-repeat: no-repeat;
border-top: 0;
min-height: 100vh;
height: 100vh !important;
position: relative;
text-align: center;
overflow: hidden;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div  id="banner">
     
     </div>
    </form>
</body>
</html>
