<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxSliderDemo.aspx.cs" Inherits="WebFormCases2.AjaxTookKitDemo.AjaxSliderDemo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.9.1.js"></script>
    <style>
        .test{
            display:inline-block
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
     
        <ajaxToolkit:SliderExtender ID="SliderExtender1" runat="server" RailCssClass="ajax__slider_h_rail test" TargetControlID="txtDisplayValue" Steps="5"  Maximum="5" Minimum="1" BoundControlID="Label1">  
      
              
</ajaxToolkit:SliderExtender>
            <asp:TextBox ID="txtDisplayValue" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>    
            </div>
        
     </form> 
</body>
</html>
