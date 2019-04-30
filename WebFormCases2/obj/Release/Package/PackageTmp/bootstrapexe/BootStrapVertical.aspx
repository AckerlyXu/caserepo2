<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BootStrapVertical.aspx.cs" Inherits="WebFormCases2.bootstrapexe.BootStrapVertical" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <style>
      .content_card--left---heading{
          /*-ms-transform:rotate(-90deg) translateX(-50%)!important;-webkit-transform:rotate(-90deg) 
          translateX(-50%)!important;transform:rotate(-90deg)   translateY(-75%) !important;*/
                                 
        font-size:3rem;font-weight:700;text-align:center;white-space:nowrap;
        position:absolute;
        left:50%;
        top:50%;
        transform:translate(-50%,-50%)
      }
         
     
  </style>
     
       <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server" >
      <div class="card flex-row flex-wrap col-6 p-0" style="margin:100px">
        <div class="card-header border-0 col-1 " style="position:relative;overflow:hidden">
           <h4 class="content_card--left---heading" >2<br />0<br />1<br />0<br />2<br />0<br />1<br />9</h4>
        </div>
        <div class="card-block  col-11 m-0" style="padding:0!important">
             <img src="../images/WingtipToys/boatbig.png" alt="" width="100%" height="100%">
        </div>
       
      
    </div>
    </form>
</body>
</html>
