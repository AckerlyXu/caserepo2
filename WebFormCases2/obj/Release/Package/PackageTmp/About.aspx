<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormCases2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <%
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            %>
     <a href="About.aspx">login out</a>
        <% }
            else
            { %>
                   <a href="About.aspx">login in</a>
              <% } %>
   

    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <img src="images/WingtipToys/boatpaper.png" />
    <asp:Button ID="Button1" runat="server" Text="set session" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="get session" OnClick="Button2_Click" />

    <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound">
        <Columns>
           
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" Text="Button" ID="book" />
                    <asp:Label ID="Label4" runat="server" Text="Please log in"></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div id='calendar'></div>

    <asp:Label ID="Label1" runat="server" Text="" ></asp:Label><script src="/Scripts/jquery-1.9.1.js"></script>
    <link href="https://fullcalendar.io/assets/demo-topbar.css" rel="stylesheet" />
    <link href="https://fullcalendar.io/releases/fullcalendar/3.9.0/fullcalendar.min.css" rel="stylesheet" />
  
       <link href="https://fullcalendar.io/releases/fullcalendar/3.9.0/fullcalendar.print.css" rel="stylesheet"  media='print'/>
    <script src="https://fullcalendar.io/releases/fullcalendar/3.9.0/lib/moment.min.js"></script>
  
    <script src="https://fullcalendar.io/releases/fullcalendar/3.9.0/lib/jquery.min.js"></script>
    <script src="https://fullcalendar.io/releases/fullcalendar/3.9.0/fullcalendar.min.js"></script>
    <script src="https://fullcalendar.io//assets/demo-to-codepen.js"></script>
    <script>
       $.ajax({
            type: "POST",
           url: "/Services/MyService.asmx/HelloWorld",
         //   data: "{ user_id: '" + 1006 + "'}",
           data: JSON.stringify( { user_id: 1006 } ),
            contentType: "application/json",
            datatype: "json",
           success: function (data) {
               console.log(data);
           },
              
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                
            }
        });


    //    $(function () {
    //    var eventsArray = [{

    //        title: 'Test1',
    //        start: "2018-12-16T00:00:00",
    //        end: "2018-12-19T00:00:00",
    //        allDay: true,
    //        editable: true
    //    },
    //    {

    //        title: 'Test2',
    //        start: "2018-12-18T00:00:00",
    //        end: "2018-12-19T00:00:00",
    //        allDay: true,
    //        editable: false

    //    }
    //    ];
          
    //        $('#calendar').fullCalendar({
    //            header: {
    //                left: 'prev,next today',
    //                center: 'title',
    //                right: 'month,agendaWeek,agendaDay'
    //            },
    //            editable: true,
    //            eventLimit: true, // when too many events in a day, show the popover
    //            events: [{ title: { a: "a" } }],
    //        eventResize: function (event, delta) {
    //            event.editable = false;
    //            console.log(this);
    //        },
    //        eventDropStart: function (event) {
    //            eventsArray[0].editable = false;
    //            event.editable = false;
                
    //        },
    //        eventRender: function (event, element) {
           
    //          //  console.log(event);
    //            console.log(event);
    //        } ,
    //        eventDrop: function (event, delta) {
    //            eventsArray[0].editable = false;
    //            event.editable = false;
                
    //        },
    //        eventDragStop: function (event) {
    //            console.log(event);
    //        }

    //        });



    //        $('div[id*=calender]').fullCalendar({
    //                header: {
    //                    left: 'prev,next today',
    //                    center: 'title',
    //                    right: 'month,agendaWeek,agendaDay'
    //                },
    //                editable: true,
    //                events: eventsArray
    //            });
                
           
    //})

    </script>




</asp:Content>
