<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartjsExe2.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.ChartjsExe2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script src="https://cdn.jsdelivr.net/npm/chart.js@2.8.0"></script>
      <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
</head>
<body>
    <form id="form1" runat="server">
     
      
        <canvas id="chart-canvaspn1" width ="100" height="50"></canvas>
    </form>

    <script>


        new Chart(document.getElementById("chart-canvaspn1").getContext('2d'),

            {
                type: 'horizontalBar', data: {
                    labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],

                    datasets: [{
                        data: [65, 59, 75, 81, 56, 55, 40], label: "Calories",
                        borderColor: "#3e95cd", backgroundColor: "#ffc266",
                        backgroundColor: "#ffc266", scaleShowGridLines: false,showScale: false,fill: true
                    }]
                },

                options: {
                    title: { display: true }, legend: { position: 'bottom' }, scales: {
                        xAxes: [{ gridLines: { display: false }, ticks: { beginAtZero: true },  }],

                        yAxes: [{ gridLines: { display: false },maxBarThickness: 10 }]
                    }
                }
            },
            { responsive: true}
        )

    </script>
</body>
</html>
