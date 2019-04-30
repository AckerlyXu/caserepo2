<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="momentjsExe.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.momentjsExe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.24.0/moment.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
    <script>
        function getTimeInterval(startTime, endTime, lunchTime) {

            var start = moment(startTime, "HH:mm");
          

     var end = moment(endTime, "HH:mm");

   var minutes = end.diff(start, 'minutes');

   var interval = moment().hour(0).minute(minutes);

    interval.subtract(lunchTime, 'minutes');
        
    return interval.format("HH:mm");

        }

        var EndTimeRegularWkHr = getTimeInterval("09:00", "08:30");
        
        var date = new Date("0000-01-01 09:00");
        date.setHours(date.getHours() + 5, date.getMinutes() + 30);
        console.log(date.getHours() + ":" + date.getMinutes());
    </script>
</html>
