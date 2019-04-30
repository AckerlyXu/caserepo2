<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mutileveldata.aspx.cs" Inherits="WebFormCases2.sqldbexe.mutileveldata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- first level --%>
        <% foreach (var item in RootNode.ChildNodes)
            {
              
                
              %>
       
        <div style="padding-left:0px;color:red "><%=item.NodeName %>  </div>
       
            <%

                    foreach (var item1 in item.ChildNodes)
                    {%>
         <%-- second level --%>
                           <div style="padding-left:20px;color:blue "><%=item1.NodeName %>  </div>
                    
                             <%foreach (var item2 in item1.ChildNodes)
                                 {%>
         <%-- third level --%>
               <div style="padding-left:40px;color:orange "><%=item2.NodeName %>  </div>
                                 <%} %>

                    <%}





                } %>
    </form>
</body>
</html>
