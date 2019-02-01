Public Class JqueryPlugins
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub button1_onclick(sender As Object, e As EventArgs)
        Response.Write(DateTime.Now.Millisecond)

    End Sub
End Class