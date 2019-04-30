<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqueryAutocompleteExe.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.JqueryAutocompleteExe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
  <link rel="stylesheet" href="/resources/demos/style.css" />
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="ui-widget">
  <label for="tags">Tags: </label>
  <input id="tags"  />
          
</div>
    </form>
</body>
    <script>
        $(function () {


          
        
    var availableTags = [
      "ActionScript",
      "AppleScript",
      "Asp",
      "BASIC",
      "C",
      "C++",
      "Clojure",
      "COBOL",
      "ColdFusion",
      "Erlang",
      "Fortran",
      "Groovy",
      "Haskell",
      "Java",
      "JavaScript",
      "Lisp",
      "Perl",
      "PHP",
      "Python",
      "Ruby",
      "Scala",
      "Scheme"
            ];
      
    $( "#tags" ).autocomplete({
        source: availableTags
       

            });
          
        });
        

        $("#tags").on("keyup", function () {
            var self = $(this);
            // wait for 300 ms , or you may clear the content before the result returns.
              setTimeout(function () {
    if ($(".ui-autocomplete").html() == "" || $(".ui-autocomplete").css("display") == "none") {
     self.val("");
                }

            },300)
             

        })
         

    </script>
</html>
