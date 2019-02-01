Imports System.Web.Optimization

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Fires when the application is started
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
    Sub Application_BeginRequest(sender As Object, e As EventArgs)
        Dim mode As String = ConfigurationManager.AppSettings("mode")

        'Dim url As Uri = Request.Url
        'If Not url.AbsolutePath.ToLower().StartsWith("/" + mode) Then
        '    If mode = "production" Then
        '        If url.AbsolutePath.ToLower().StartsWith("/development") Then
        '            Dim target As String = url.AbsolutePath.Substring(12)
        '            HttpContext.Current.RewritePath("/" + mode + target)
        '        End If


        '    End If
        '    If mode = "development" Then
        '        If url.AbsolutePath.ToLower().StartsWith("/production") Then
        '            Dim target As String = url.AbsolutePath.Substring(11)
        '            HttpContext.Current.RewritePath("/" + mode + target)
        '        End If


        '    End If
        'End If





    End Sub

End Class