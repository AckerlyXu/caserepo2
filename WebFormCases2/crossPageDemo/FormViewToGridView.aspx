<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormViewToGridView.aspx.cs" Inherits="WebFormCases2.crossPageDemo.FormViewToGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="FormView1" runat="server" DefaultMode="Insert">
            <InsertItemTemplate>
                <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </InsertItemTemplate>
        </asp:FormView>
    </form>

    <div class="modal" tabindex="-1" role="dialog" data-backdrop="false">
  <div class="modal-dialog" role="document" >
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
       <iframe src="openedGridview.aspx">

       </iframe>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>


  <script src="https://code.jquery.com/jquery-3.3.1.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
</body>
    <script>
        
        $(function () {
            var textBox = $("[id*=TextBox1]");
            console.log(textBox);
            textBox.click(function () {
                $(".modal").modal();
            })
          
           
            
        })
        function getTextbox() {
            return $("[id*=TextBox1]");
        }
       
    </script>
</html>
