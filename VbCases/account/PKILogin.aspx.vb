Public Class PKILogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Banner1.Jpg,banenr2.jpb,banner3.jpg".Substring(0, "Banner1.Jpg,banenr2.jpb,banner3.jpg".IndexOf(",")))
    End Sub

End Class