<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="highlightdynamic.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.highlight.highlightdynamic" %>

<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Product Gallery With Image Zoom Example</title>

    <link rel="stylesheet" href="css/main.css">
    <link href="https://www.jqueryscript.net/css/jquerysctipttop.css" rel="stylesheet" type="text/css">
    <style>

        body {
            background-color: #fafafa;
            min-height: 100vh;
        }

        .container {
            margin: 150px auto;
           width:500px;
        }
    </style>
    <script src="jquery.min.js"></script>

    <script src="jquery.maphilight.min.js"></script>
  
    <script type="text/javascript">
        $(function () {
            $(".map").maphilight()
            $(".icon-right,.icon-left,#small-img-roll img").click(
                function () {
                    //$("div.map img").css("opacity", 1);
                    //$(".map").maphilight()
                    var name = $("#small-img-roll img[alt=now]").data("id");
                    $("#show-img").attr("usemap", "#" + name);
                     $("div.map img").css("opacity", 1);
                    $(".map").maphilight()
                     
                }


            )

        })

         
    </script>
</head>
<body>
      <form id="form1" runat="server">
    <div class="container">
        <h1>Product Gallery With Image Zoom Example</h1>

        <div class="small-img">
            <img src="images/online_icon_right@2x.png" class="icon-left" alt="" id="prev-img">
            <div class="small-container">
                <div id="small-img-roll">
                    <asp:Repeater ID="Repeater3" runat="server">
                        <ItemTemplate>
                             <img src='<%#Eval("Path") %>'  data-id='<%# Eval("Id") %>'   class="show-small-img" alt="">
                        </ItemTemplate>

                    </asp:Repeater>
                   
                </div>
            </div>



            <!--<script src="https://code.jquery.com/jquery-3.3.1.min.js" integrity="sha384-tsQFqpEReu7ZLhBV2VZlAu7zcOV+rXbYlF2cqB8txI/8aZajjp4Bqd+V6D5IgvKT" crossorigin="anonymous"></script>-->


            <img src="images/online_icon_right@2x.png" class="icon-right" alt="" id="next-img">
        </div>
        <!--<div class="show" href="images/1.png" usemap="#enewspaper">-->

        <asp:Repeater ID="Repeater4" runat="server">

            <ItemTemplate>
                  <img src='<%#Eval("Path") %>'  id="show-img" usemap='<%# "#"+Eval("Id") %>' class="map">
           

            </ItemTemplate>
        </asp:Repeater>
       

        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
              
            <ItemTemplate>
  <map name='<%# Eval("Id") %>'>
      <asp:Repeater ID="Repeater2" runat="server">

          <ItemTemplate>
            <area shape='<%# Eval("Shape") %>' coords='<%# Eval("Coords") %>' />
          
          </ItemTemplate>
      </asp:Repeater>
          
        </map>
            </ItemTemplate>
        </asp:Repeater>
      

    </div>
  

<script src="scripts/zoom-image.js"></script>
  <script src="scripts/main.js"></script>

     </form>
</body>


</html>

