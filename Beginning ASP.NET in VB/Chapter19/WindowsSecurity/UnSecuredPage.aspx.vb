
Partial Class UnSecuredPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblInfo.Text = "Are you authenticated? "
        lblInfo.Text &= User.Identity.IsAuthenticated
    End Sub

    Protected Sub cmdGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        Response.Redirect("SecuredPages/SecuredPage.aspx")
    End Sub
End Class
