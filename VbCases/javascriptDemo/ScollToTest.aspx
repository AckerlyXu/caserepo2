<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ScollToTest.aspx.vb" Inherits="VbCases.ScollToTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  />
            </ContentTemplate> 
        </asp:UpdatePanel>
        <div style="height:1000px">
        </div>
       
       <a name="hlTest" id="hlTest" runat="server" href="#"><label runat="server">Start here.</label></a>
          <div style="height:1000px">
        </div>


       
    </form>
    <script>
        //window.onload = function () {
        //    window.location.hash="#hlTest"
        //}
    
 
    Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(
 
       function(sender, evgs)
 
       {
           //window.location.hash = "";
           //window.location.hash = "#hlTest"
           //console.log(sender, evgs);
 
       });
 

    </script>
</body>
</html>
