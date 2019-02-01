<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LimitUploadSize.aspx.cs" Inherits="WebFormCases2.fileDemo.LimitUploadSize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
  
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
      <%--  <asp:FileUpload ID="FileUpload1" runat="server" />--%>
        <asp:Button ID="Button1" runat="server" Text="upload" />
        <input type="text"  id="date"/>
        <input type="text"  id="d"/>
        
    </form>

    <script>
  
  
          $(function () {
                       $( "#date" ).datepicker();

            $("#FileUpload1").change(

               
                function () {

                  

                
                    var eles = $(this)[0].files;
                    for (var i = 0; i < eles.length; i++) {
                      
                        if (eles[0].size/1024 > 200) {
                            $("#Button1").prop("disabled", true);
                            alert("size beyond 200 kb");
                            return;
                        }
                    }
                     $("#Button1").prop("disabled", false);

                })
        });
       
    </script>
</body>
</html>
