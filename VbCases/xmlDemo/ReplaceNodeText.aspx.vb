

Imports System.Xml

Public Class ReplaceNodeText
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strXML As String = "<NewDataSet>
<CUSTOMERINFO>
<CARD_NUMBER>12121212121212</CARD_NUMBER>
<TYPE_OF_CARD>VI</TYPE_OF_CARD>
<CARD_EXPIRATION_DATE>0623</CARD_EXPIRATION_DATE>
<BANK_ACCOUNT_NUMBER>2036220196290</BANK_ACCOUNT_NUMBER>
<ACCOUNT_STATUS>A</ACCOUNT_STATUS>
<IS_DEFAULT>N</IS_DEFAULT>
<OPTION_TYPE>R</OPTION_TYPE>
<CREATED_DATE>2016-04-11T11:02:13-04:00</CREATED_DATE>
<ACCOUNTREFID>100001</ACCOUNTREFID>
<ENTITY>BILLPAY</ENTITY>
<VALUE>9950</VALUE>
</CUSTOMERINFO>
</NewDataSet>"

        Dim doc As XmlDocument = New XmlDocument()
        doc.LoadXml(strXML)
        Dim list As XmlNodeList = doc.SelectNodes("//CARD_NUMBER|//TYPE_OF_CARD|//BANK_ACCOUNT_NUMBER")
        For Each node As XmlNode In list
            If (node.Name = "CARD_NUMBER") Then
                node.InnerText = "&*&*&*&*&**^%^%"
            End If

            If (node.Name = "BANK_ACCOUNT_NUMBER") Then
                node.InnerText = "&^^^&^&^&^&*&*(**^"
            End If
            If (node.Name = "TYPE_OF_CARD") Then
                node.InnerText = "%$%$%$%$$%$%$%$%"
            End If

        Next
        doc.Save(Server.MapPath("/xmlDemo/test.xml"))
    End Sub

    Private Function ReplaceSpecial(ByVal xmlStr As String) As String
        xmlStr = xmlStr.Replace("&", "&amp;")
        xmlStr = xmlStr.Replace("<", "&lt;")
        xmlStr = xmlStr.Replace(">", "&gt;")
        xmlStr = xmlStr.Replace("""", "&quot;")
        xmlStr = xmlStr.Replace("'", "&apos;")
        Return xmlStr
    End Function

End Class