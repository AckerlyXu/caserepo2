<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TwoDatePickers.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.TwoDatePickers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
 <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"type="text/javascript"></script>
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet"type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="Textbox1" runat="server"></asp:TextBox>
<asp:TextBox ID="Textbox2" runat="server"></asp:TextBox>
    </form>
</body>

     <script>
         var date = new Date(); //get the current data
         date.setDate(new Date().getDate() + 29);// set its data to 29 later
       $(document).ready(function() {
    $('#' + '<%= Textbox2.ClientID %>').datepicker({
      changeMonth: true,
      dateFormat: 'dd/mm/yy',
      changeYear: true,
        numberOfMonths: 2,
        minDate:date,  // set datapicker2's min  date to 29 later
     showMonthAfterYear: true
           });
        


  $('#' + '<%= Textbox1.ClientID %>').datepicker({
    changeMonth: true,
      changeYear: true,
      dateFormat: 'dd/mm/yy',
     numberOfMonths: 2,
    minDate: 0,
    showMonthAfterYear: true,
onSelect: function (selectedDate) {  
          var date2 = $(this).datepicker('getDate');
         date2.setDate(date2.getDate()+29);//set date +X day
         $('#'+'<%= Textbox2.ClientID %>').datepicker("option", "minDate",date2 );
             setTimeout(function () {          
             $('#' + '<%= Textbox2.ClientID %>').datepicker("show");// show to-datepicker
        },400)
      }


           })
           //set datapicker1's data to today
 $('#' + '<%= Textbox1.ClientID %>').datepicker('setDate',Date.now())  
})

        </script>   
</html>
