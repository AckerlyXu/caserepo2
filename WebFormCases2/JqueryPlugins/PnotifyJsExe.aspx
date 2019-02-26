<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PnotifyJsExe.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.PnotifyJsExe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js" ></script>

   
    <link href="pnotify.custom.min.css" rel="stylesheet" />
     <script src="pnotify.custom.min.js"></script>
     <script>      
    function showMessage(title, msg)
    {        
        debugger;
        new PNotify({
            title: title,            
            text: msg,
            type: 'success',
            delay: 500
        });
    }
</script>
</head>
<body>
      
    
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>


    </form>
</body>
</html>
