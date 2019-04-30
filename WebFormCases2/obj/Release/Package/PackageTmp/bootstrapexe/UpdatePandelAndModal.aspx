<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePandelAndModal.aspx.cs" Inherits="WebFormCases2.bootstrapexe.UpdatePandelAndModal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
  Launch demo modal
</button>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
          <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="click" />
            </Triggers>
            <ContentTemplate>

          
        <div id="myModal" class="modal" tabindex="-1" role="dialog">
     <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
           <asp:DropDownList ID="ddl_parentreasoncode" Width="170px" runat="server" OnSelectedIndexChanged="ddl_parentreasoncode_SelectedIndexChanged" AutoPostBack="true">
                   <asp:ListItem>1</asp:ListItem>
               <asp:ListItem>2</asp:ListItem>
               <asp:ListItem>3</asp:ListItem>
                    </asp:DropDownList>
                    <asp:HiddenField ID="hidden_tgt_machine_reasoncode" runat="server" ClientIDMode="Static"></asp:HiddenField>
                </td>
                <td><div class="gap"></div></td>
                <td>
                    <asp:DropDownList ID="ddl_childreasoncode" Width="170px" runat="server" 
                     >
                        

                    </asp:DropDownList>

        <p>Modal body text goes here.</p>
                    </ContentTemplate>
            </asp:UpdatePanel>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
          </ContentTemplate>
        </asp:UpdatePanel>
                
    </form>
     <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
    
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
<script>
    function enablePopUpModal() {
        document.getElementById("myModal").style.display = "block";
    console.log("hello");
    
}
</script>
</body>
    
</html>
