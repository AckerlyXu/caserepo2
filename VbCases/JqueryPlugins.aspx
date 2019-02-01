<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="JqueryPlugins.aspx.vb" Inherits="VbCases.JqueryPlugins" %>

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
        <asp:TextBox ID="TextBox1" runat="server"  ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="TextBox1_TextChanged" style="display:none" />
    </form>
    <script>
        $(function () {
            $("#TextBox1").datepicker(
              
            );  // make the textbox become a datepicker


              $("#TextBox1").datepicker(// change the format of the datepicker
              "option", "dateFormat", "yy-mm-dd"
            );
            var now =new Date( );
         
            $("#TextBox1").datepicker("setDate",now);// set the datepicker's date to now

            $("#TextBox1").change(function (e) {// bind change event of textbox1
               
                var currentDate = $("#TextBox1").datepicker("getDate");// get user's date
             
                var now = new Date(new Date().getFullYear(), new Date().getMonth(), new Date().getDate());
               

                if (currentDate < now) {// compare use date with now
                  var result = confirm(" are you sure?");
                    if (!result) {  // if user cancel the choice , reload the page
                        window.location.href = "http://localhost:56759/JqueryPlugins";

                        return;
                    } 
                }
                // else trigger the button's click event.
                $("#Button1").click();
            })
        })
       
        	
        
    </script>
</body>
</html>
