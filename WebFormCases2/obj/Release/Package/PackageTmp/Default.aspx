<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormCases2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <%-- <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <script>
        $(function () {
            console.log($("#<%=Button1.ClientID%>"));
        })
    </script>--%>
    <h1>I'm  default.aspx</h1>
    <asp:Button ID="Button4" runat="server" Text="add my seession" OnClick="Button4_Click" />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="expire"  OnClick="Button2_Click"/>
    <asp:Button ID="Button3" runat="server" Text="set cookie" OnClick="Button3_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Content>
