Public Class ScollToTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Response.Write("<script>window.location.hash='#hlTest'</script>")

        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "scroll", "window.location.hash='#hlTest'", True)
        '  Response.Write("<script>window.location.hash='#hlTest'</script>")
        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "scroll", "window.location.href='/javascriptDemo/ScollToTest#hlTest'", True)
    End Sub
End Class