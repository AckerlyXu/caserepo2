<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridviewOpenModelPop.aspx.cs" Inherits="WebFormCases2.bootstrapexe.GridviewOpenModelPop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
 <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                  <asp:BoundField  DataField="name" HeaderText="name"/>
               <asp:TemplateField HeaderText=" show edit pop up">
                   <ItemTemplate >
                        <asp:LinkButton runat="server" ID="link" CommandArgument='<%# Eval("id") %>' OnClick="link_Click">edit</asp:LinkButton>
                   </ItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>


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
          <asp:Label ID="Label1" runat="server" Text="name:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
          <asp:Label ID="Label2" runat="server" Text="id:" /><asp:Label ID="Label3" runat="server" Text="Label"/>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
    </form>
</body>
</html>
