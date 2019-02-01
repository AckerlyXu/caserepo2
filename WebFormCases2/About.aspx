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


    <asp:Label ID="Label1" runat="server" Text="" ></asp:Label><script src="/Scripts/jquery-1.9.1.js"></script>
    <script>
        window.onload = function () {
             document.onclick = function (e) {
                 console.log(e);
                 
        }
        }
       
    </script>


</asp:Content>
