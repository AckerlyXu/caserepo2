Imports CrystalDecisions.CrystalReports.Engine

Public Class CrystalStart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cryRpt As ReportDocument = New ReportDocument()
        cryRpt.Load(Server.MapPath("~/extraConrols/CrystalReport1.rpt"))
        CrystalReportViewer1.ReportSource = cryRpt
        cryRpt.Refresh()

        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.Pdf








        ' CrystalReportViewer1.RefreshReport()

        'cryRpt.PrintToPrinter(1, False, 0, 0)


    End Sub

End Class