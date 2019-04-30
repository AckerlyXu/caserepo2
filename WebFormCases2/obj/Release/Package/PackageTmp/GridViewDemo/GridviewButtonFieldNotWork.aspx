<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridviewButtonFieldNotWork.aspx.cs" Inherits="WebFormCases2.GridViewDemo.GridviewButtonFieldNotWork" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">

            <ContentTemplate>
                 <asp:GridView ID="grdDStaff" runat="server" AutoGenerateColumns="False" CssClass="GridStyle" >
    <Columns>
    
      
        <asp:ButtonField Text="History" CommandName="View" ButtonType="Link">
            <ControlStyle ForeColor="#666666" />
        </asp:ButtonField>
    </Columns>
  
</asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </form>
</body>
</html>
