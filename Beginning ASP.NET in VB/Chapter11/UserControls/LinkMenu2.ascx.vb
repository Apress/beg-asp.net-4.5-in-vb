
Partial Class LinkMenu2
    Inherits System.Web.UI.UserControl

    Public Event LinkClicked As EventHandler(Of LinkClickedEventArgs)

    Protected Sub lnk_Click(ByVal sender As Object, _
      ByVal e As System.Web.UI.WebControls.CommandEventArgs) Handles _
      lnkBooks.Command, lnkFurniture.Command, lnkSports.Command, lnkToys.Command

        ' One of the LinkButton controls has been clicked.
        ' Raise an event to the page.

        ' Pass along the link information.
        Dim args As New LinkClickedEventArgs(e.CommandArgument)
        RaiseEvent LinkClicked(Me, args)

        ' Perform the redirect.
        If Not args.Cancel Then
            ' Notice this code uses the Url from the LinkClickedEventArgs
            ' object, not the original link. That means the web page
            ' can change the link if desired before the redirect.
            Response.Redirect(args.Url)
        End If
    End Sub

End Class
