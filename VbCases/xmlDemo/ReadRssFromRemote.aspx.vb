Imports System.IO
Imports System.Net
Imports System.Xml

Public Class ReadRssFromRemote
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim MyRssDocument As XmlDocument = New XmlDocument()
        Dim MyRssRequest As HttpWebRequest = Nothing
        Dim MyRssResponse As HttpWebResponse = Nothing

        Dim sURL As String = "https://tradingeconomics.com/united-states/rss"

        Dim request As HttpWebRequest = CType(WebRequest.Create(sURL), HttpWebRequest)
        request.Method = "GET"
        request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)"
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()

        reader.Close()
        dataStream.Close()
        response.Close()

        'NEW

        MyRssDocument.LoadXml(responseFromServer)
        'ABOVE LINE ERROR System.Xml.XmlException: Data at the root level is invalid. Line 1, position 1.

        reader.Close()

        Dim MyRssList As XmlNodeList = MyRssDocument.SelectNodes("rss/channel/item")

        Dim x As Integer = MyRssList.Count

        MsgBox("Done!: RSS lines found: " & x.ToString)
    End Sub

End Class