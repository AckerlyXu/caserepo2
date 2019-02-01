<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="binddropdownwithjs.aspx.cs" Inherits="WebFormCases2.dropdownDemo.binddropdownwithjs"
   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
</head>
<body>
    
    <form id="form1" runat="server">
     
       <asp:DropDownList ID="Region" runat="server" >
            
        </asp:DropDownList>
      
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
    </form>

    

</body>
</html>
