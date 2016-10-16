
Partial Class SecuredPages_SecuredPage
    Inherits System.Web.UI.Page

    Protected Sub cmdSignOut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSignOut.Click
        FormsAuthentication.SignOut()
        Response.Redirect("~/Login.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMessage.Text = "You have reached the secured page, "
        lblMessage.Text &= User.Identity.Name & "."
    End Sub
End Class
