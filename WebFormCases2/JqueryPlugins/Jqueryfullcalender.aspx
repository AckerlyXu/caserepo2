<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jqueryfullcalender.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.Jqueryfullcalender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<%--<script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>--%>
    <link href="https://fullcalendar.io/assets/demo-topbar.css" rel="stylesheet" />
    <link href="https://fullcalendar.io/releases/fullcalendar/3.9.0/fullcalendar.min.css" rel="stylesheet" />
  <link rel="stylesheet" type="text/css" href="assets/css/bootstrap-year-calendar.min.css"/>
       <link href="https://fullcalendar.io/releases/fullcalendar/3.9.0/fullcalendar.print.css" rel="stylesheet"  media='print'/>
    <script src="https://fullcalendar.io/releases/fullcalendar/3.9.0/lib/moment.min.js"></script>
  
    <script src="https://fullcalendar.io/releases/fullcalendar/3.9.0/lib/jquery.min.js"></script>
    <script src="https://fullcalendar.io/releases/fullcalendar/3.9.0/fullcalendar.min.js"></script>
    <script src="https://fullcalendar.io//assets/demo-to-codepen.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="calendar">
        </div>
        
    </form>

    <script>
    

        $(function () {

            $.ajax({
                type: "POST",
                url: "/Services/MyService.asmx/HelloWorld",

                data: JSON.stringify({ user_id: 1006 }),
                contentType: "application/json",
                datatype: "json",
                success: function (data) {
                    // map the array element to object with property title and start
                    // you could log the data to see the result
                 //    data = data.d.map(function (e) {
                 //       var obj = {title:e["training_title"],start:e.date}

                 //       return obj;
                 //})

                    //define an array to store the final data
                    var target = [];
                    // loop through data.d array
                    for (var i = 0; i < data.d.length; i++) {
                         //get training_title and set to an object's title property ,get date and set the object's start property to date.
                        var item = { title: data.d[i]["training_title"], start: data.d[i]["date"] }
                        // add the item to the target array
                        target.push(item);
                    }
                $('#calendar').fullCalendar({
          
                    editable: false,
            events: target  // use the target array as events'  datasrouce
       
 
    })
                },

                error: function (XMLHttpRequest, textStatus, errorThrown) {

                }
            });


        })  


</script>
</body>
</html>
