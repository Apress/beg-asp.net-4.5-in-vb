Partial Class Cookieless2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("test") Is Nothing Then
            lblInfo.Text = "Session information not found."
        Else
            lblInfo.Text = "Successfully retrieved " & CType(Session("test"), String)
        End If

    End Sub
End Class
