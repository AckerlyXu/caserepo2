Public Class ScrollToConditionally
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If TextBox1.Text = "no" Then
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "scroll", "setTimeout(function(){window.scrollTo(0,0)},0)", True)
        End If
    End Sub

End Class