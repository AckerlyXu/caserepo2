<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bootstrapfullcalendar.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.bootstrapfullcalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap-year-calendar.css" rel="stylesheet" />
 <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <%--  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
         <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>--%>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
  
    <script src="bootstrap-year-calendar.js"></script>

</head>
<body>
    <form id="form1" runat="server">
       <div id="calendar">
        </div>
        
    </form>

       <script>
    
           function parseStringToDate(dateString) {
               var ymd = dateString.split(" ")[0].split("/");
               var mydate = new Date(parseInt(ymd[2]), parseInt(ymd[0])-1, parseInt(ymd[1]))
               return mydate;
            
           }
        $(function () {
            
            $.ajax({
                type: "POST",
                url: "/Services/MyService.asmx/HelloWorld",
                async:false,
                data: JSON.stringify({ user_id: 1006 }),
                contentType: "application/json",
                datatype: "json",
                success: function (data) {
                   
                    var target = [];
                    // loop through data.d array
                    for (var i = 0; i < data.d.length; i++) {
                        //2/24/2019 12:00:00 AM
                        //get training_title and set to an object's title property ,get date and set the object's start property to date.
                       
                        var item = { name: data.d[i]["training_title"], startDate:parseStringToDate(data.d[i]["date"]) , endDate:parseStringToDate(data.d[i]["date"])  }
                        // add the item to the target array
                        target.push(item);
                    }
                $('#calendar').calendar({
          
                    enableContextMenu: true,
                 enableRangeSelection: true,
              dataSource: target  // use the target array as events'  datasrouce
       
 
    })
                },

                error: function (XMLHttpRequest, textStatus, errorThrown) {

                }
            });

         
               
        })  


</script>
</body>
</html>
