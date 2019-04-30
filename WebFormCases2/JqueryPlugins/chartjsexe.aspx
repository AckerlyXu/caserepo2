<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chartjsexe.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.chartjsexe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>


canvas {
  border: 1px dotted red;
}

.chart-container {
  position: relative;
  margin: auto;
  height: 50vh;
  width: 60vw;
}
    </style>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@2.8.0"></script>
      <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       <div class="chart-container">
      <canvas id="myChart"  width="400" height="400"></canvas>
</div>
   </div>
    </form>

    <script>
//var ctx = document.getElementById('myChart').getContext('2d');
//var chart = new Chart(ctx, {
//    // The type of chart we want to create
//    type: 'bar',

//    // The data for our dataset
//    data: {
//        labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
//        datasets: [{
//            label: 'My First dataset',
//            backgroundColor: 'rgb(255, 99, 132)',
//            borderColor: 'rgb(255, 99, 132)',
//            data: [0, 10, 5, 2, 20, 30, 45]
//        }]
//    },

//    // Configuration options go here
//    options: {}
//});

        var data = {
  labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul"],
  datasets: [{
    label: "Dataset #1",
    backgroundColor: "rgba(255,99,132,0.2)",
    borderColor: "rgba(255,99,132,1)",
    borderWidth: 2,
    hoverBackgroundColor: "rgba(255,99,132,0.4)",
    hoverBorderColor: "rgba(255,99,132,1)",
    data: [65, 59, 20, 81, 56, 55, 40],
  }]
};

var options = {
    maintainAspectRatio: false,
    legend: {
        position:"bottom",
            display: true,
            labels: {
                fontColor: 'rgb(255, 99, 132)'
            }
        },
  scales: {
    yAxes: [{
      stacked: true,
      //gridLines: {
      //  display: true,
      //  color: "rgba(255,99,132,0.2)"
      //}
    }],
      xAxes: [{
        maxBarThickness: 50,
      gridLines: {
        display: false
      }
    }]
  }
};

Chart.Bar('myChart', {
  options: options,
  data: data
});

    </script>
</body>
</html>
