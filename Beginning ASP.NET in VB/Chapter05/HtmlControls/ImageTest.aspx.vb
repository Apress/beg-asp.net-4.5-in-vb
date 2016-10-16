
Partial Class ImageTest
    Inherits System.Web.UI.Page

    Protected Sub ImgButton_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) _
     Handles ImgButton.ServerClick

        Result.InnerText = "You clicked at (" & e.X.ToString() & _
          ", " & e.Y.ToString() & "). "

        If e.Y < 100 And e.Y > 20 And e.X > 20 And e.X < 275 Then
            Result.InnerText &= "You clicked on the button surface."
        Else
            Result.InnerText &= "You clicked the button border."
        End If

    End Sub
End Class
