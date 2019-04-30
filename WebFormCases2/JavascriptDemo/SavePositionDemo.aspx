<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SavePositionDemo.aspx.cs" Inherits="WebFormCases2.JavascriptDemo.SavePositionDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
        <asp:BulletedList ID="BulletedList1" runat="server" ></asp:BulletedList>
        <script>
          
            //function getLocation() {
            //    if (navigator.geolocation) {
            //        navigator.geolocation.getCurrentPosition(showPosition);
                 
            //    }
            //    else {alert( "Geolocation is not supported by this browser."); }
            //}
            //function showPosition(position) {


            //      $.ajax({
            //        url: '/Services/MyService.asmx/getLocation',
            //        type: 'post',
            //          dataType: 'json',
            //          data: JSON.stringify( {
                         
            //              location: "Latitude: " + position.coords.latitude +
            //        ",Longitude: " + position.coords.longitude + ",Accuracy" + position.coords.accuracy}),
            //        contentType: 'application/json',
            //        success: function (data) {
            //            alert('Success: ' + data);
            //        },
            //        error: function (error) {
            //            alert(error.statusText);
            //        }
            //    });
                

            //}

            //getLocation();
   

        </script>
    </form>
</body>
</html>
