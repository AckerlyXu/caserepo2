Public Class TimeSpanExe
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim a As TimeSpan = New TimeSpan(1543970000000)
        Dim lessThanOneDay As String = a.ToString("hh\:mm\:ss")
        Dim hms As String() = lessThanOneDay.Split(":"c)
        hms(0) = (a.Days * 24 + a.Hours).ToString()
        Response.Write(String.Join(":"c, hms))
        Response.Write("<br/>")


        Response.Write((a.Days * 24 + a.Hours) & ":" & a.Minutes & ":" & a.Seconds)
    End Sub

End Class