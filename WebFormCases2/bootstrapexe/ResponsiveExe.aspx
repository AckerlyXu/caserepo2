<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResponsiveExe.aspx.cs" Inherits="WebFormCases2.bootstrapexe.ResponsiveExe" %>



<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head3" runat="server">
<title>On Grounds</title>
<style type="text/css">
.auto-style1 {
width: 30vw;
height: 10vh;
}
.auto-style4 {
width: 10vw;
height:10vh;
}
.auto-style5 {
width: 60vw;
height: 10vh;
}
</style>
</head>
<body>
<form id="form3" runat="server">
<h2>
<asp:Image ID="Image1" runat="server" Height="103px" Width="216px" ImageUrl="~/headerLogo.png" />
</h2>
<h2>
Instructor</h2>
<h2>
Enter Email Address</h2>
<table>
<tr>
<td class="auto-style4">Email Address:</td>
<td class="auto-style5">
<asp:TextBox ID="txtRecordID" runat="server" Width="225px"></asp:TextBox>
</td>
<td class="auto-style1">
    111111111111111111
</td>
    </tr>

</table>
<br />
<asp:Button ID="btnEnterEmail" runat="server" Text="Submit"  />
<br />
<asp:Panel ID="Panel1" runat="server" Width="333px">
<br />
Instructions/Notes:
<br />
-Enter Your Parker.edu eMail Address.</asp:Panel>
<br />
<asp:Label ID="Label2" runat="server" EnableViewState="False"></asp:Label>
<br />
</form>
</body>
</html>