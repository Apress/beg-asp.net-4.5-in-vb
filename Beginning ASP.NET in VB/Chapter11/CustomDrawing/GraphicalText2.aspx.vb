Imports System.Drawing

Partial Class GraphicalText2
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Get the user name.
        If Request.QueryString("Name") Is Nothing Then
            ' No name was supplied.
            ' Don't display anything.
        Else
            Dim name As String = Request.QueryString("Name")

            ' Create an in-memory bitmap where you will draw the image.
            Dim image As New Bitmap(300, 50)

            ' Get the graphics context for the bitmap.
            Dim g As Graphics = Graphics.FromImage(image)

            g.FillRectangle(Brushes.LightYellow, 0, 0, 300, 50)
            g.DrawRectangle(Pens.Red, 0, 0, 299, 49)

            ' Draw some text based on the query string.
            Dim font As New Font("Alba Super", 20, FontStyle.Regular)
            g.DrawString(name, font, Brushes.Blue, 10, 0)

            ' Render the entire bitmap to the HTML output stream.
            image.Save(Response.OutputStream, _
              System.Drawing.Imaging.ImageFormat.Gif)

            g.Dispose()
            image.Dispose()
        End If

    End Sub
End Class
