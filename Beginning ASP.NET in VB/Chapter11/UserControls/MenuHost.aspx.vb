
Partial Class MenuHost
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Params("product") IsNot Nothing Then
            lblSelection.Text = "You chose: "
            lblSelection.Text &= Request.Params("product")
        End If
    End Sub
End Class
