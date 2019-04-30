Public Class TestDoc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rssFeed = XDocument.Load(MapPath("/LinqDemo/test.xml"))
        Dim posts = From item In rssFeed.Descendants("item").Take(2)
                    Select Title = item.Element("title").Value,
                    Published = DateTime.Parse(item.Element("pubDate").Value),
                    Url = item.Element("link").Value,
                    Description = If(item.Element("description").Value.LastIndexOf("<") = -1, item.Element("description").Value, item.Element("description").Value.Substring(0, item.Element("description").Value.LastIndexOf("<")))

        Dim a = "abc"

        Dim hel = posts.ToList()
    End Sub

End Class