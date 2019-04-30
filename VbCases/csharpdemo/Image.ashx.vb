Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web
Imports System.Web.Services

Public Class Image
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest


        Dim path As String = context.Request.MapPath("busgreen.png")
        Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)

        Dim imageWithWhiteBorder As System.Drawing.Image

        imageWithWhiteBorder = AppendBorder(System.Drawing.Image.FromFile(path), 20)
        imageWithWhiteBorder.Save(context.Request.MapPath("whiteborder.png"))


        Dim watermarkText As String = "www.example.com"

        'Get the file name.
        Dim fileName As String = "whiteborder.png"

        'Read the File into a Bitmap.
        Using bmp As New Bitmap(context.Request.MapPath("whiteborder.png"), False)
            Using grp As Graphics = Graphics.FromImage(bmp)

                'Set the Color of the Watermark text.
                Dim brush As Brush = New SolidBrush(Color.Black)

                'Set the Font and its size.
                Dim font As Font = New System.Drawing.Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel)

                'Determine the size of the Watermark text.
                Dim textSize As New SizeF()
                textSize = grp.MeasureString(watermarkText, font)

                'Position the text and draw it on the image.
                Dim position As New Point(0, (bmp.Height - (CInt(textSize.Height) + 10)))
                grp.DrawString(watermarkText, font, brush, position)

                Using memoryStream As New MemoryStream()
                    'Save the Watermarked image to the MemoryStream.
                    bmp.Save(memoryStream, ImageFormat.Png)
                    memoryStream.Position = 0

                    'Start file download.
                    context.Response.Clear()
                    context.Response.ContentType = "image/png"
                    '  context.Response.AddHeader("Content-Disposition", Convert.ToString("attachment; filename=") & fileName)
                    context.Response.AppendHeader("Content-Disposition", "attachment; filename=abc.png")
                    'Write the MemoryStream to the Response.
                    memoryStream.WriteTo(context.Response.OutputStream)
                    context.Response.Flush()
                    context.Response.Close()
                    context.Response.[End]()
                End Using
            End Using

        End Using


    End Sub
    Public Function AppendBorder(ByVal original As System.Drawing.Image, ByVal borderWidth As Integer) As System.Drawing.Image

        Dim borderColor As Color = Color.White
        ' Dim mypen As New Pen(borderColor, borderWidth)
        Dim totalCanvasSize As New System.Drawing.Size(512, 512)

        Dim newImageRectWithoutBorder As New System.Drawing.Rectangle(borderWidth, borderWidth, totalCanvasSize.Width - (borderWidth * 2), totalCanvasSize.Height - (borderWidth * 6))

        Dim img As New System.Drawing.Bitmap(totalCanvasSize.Width, totalCanvasSize.Height)

        Dim g As Graphics = Graphics.FromImage(img)

        'g.Clear(borderColor)   
        Dim mySolidBrush = New SolidBrush(System.Drawing.Color.White)
        g.FillRectangle(mySolidBrush, 0, 0, totalCanvasSize.Width, totalCanvasSize.Height)

        g.DrawImage(original, newImageRectWithoutBorder)

        g.Dispose()

        Return img

    End Function
    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class