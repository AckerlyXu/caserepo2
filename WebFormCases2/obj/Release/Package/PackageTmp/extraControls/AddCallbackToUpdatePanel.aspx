<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCallbackToUpdatePanel.aspx.cs" Inherits="WebFormCases2.extraControls.AddCallbackToUpdatePanel" %>

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
                <asp:Button runat="server" Text="Button" />
            </ContentTemplate>
        </asp:UpdatePanel>
       
    </form>
        <script type="text/javascript"> 
            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function (sender, args) { 
                console.log("success");
            //if (args.get_error() && args.get_error().name === 'Sys.WebForms.PageRequestManagerTimeoutException') { 
            //                args.set_errorHandled(true); 
            //} 
        }); 
    </script> 
    
</body>
 
</html>
