<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BindDataAccordingToCheckBox.aspx.vb" Inherits="VbCases.BindDataAccordingToCheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
        <%-- store categoryid in a customized property --%>
         Cars: <asp:CheckBox ID="CheckBox1" param="1" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged"  />
        Planes:<asp:CheckBox ID="CheckBox2" param="2" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged"  />
        Trucks<asp:CheckBox ID="CheckBox3" param="3" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged"  />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </form>
</body>
</html>
