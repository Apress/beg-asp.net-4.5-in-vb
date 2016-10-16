Imports System.Drawing

Partial Class GraphicalText
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Create an in-memory bitmap where you will draw the image.
        ' The Bitmap is 300 pixels wide and 50 pixels high.
        Dim image As New Bitmap(300, 50)

        ' Get the graphics context for the bitmap.
        Dim g As Graphics = Graphics.FromImage(image)

        ' Draw a solid yellow rectangle with a red border.
        g.FillRectangle(Brushes.LightYellow, 0, 0, 300, 50)
        g.DrawRectangle(Pens.Red, 0, 0, 299, 49)

        ' Draw some text using a fancy font.
        Dim font As New Font("Alba Super", 20, FontStyle.Regular)
        g.DrawString("This is a test.", font, Brushes.Blue, 10, 0)

        ' Copy a smaller gif into the image from a file.
        Dim icon As Image = System.Drawing.Image.FromFile(Server.MapPath("smiley.gif"))
        g.DrawImageUnscaled(icon, 240, 0)

        ' Render the entire bitmap to the HTML output stream.
        image.Save(Response.OutputStream, _
          System.Drawing.Imaging.ImageFormat.Gif)

        ' Clean up.
        g.Dispose()
        image.Dispose()

    End Sub
End Class
