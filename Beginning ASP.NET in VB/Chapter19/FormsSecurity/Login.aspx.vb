
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub cmdLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If txtPassword.Text.ToLower() = "secret" Then
            FormsAuthentication.RedirectFromLoginPage(txtName.Text, False)
        Else
            lblStatus.Text = "Try again."
        End If
    End Sub
End Class
