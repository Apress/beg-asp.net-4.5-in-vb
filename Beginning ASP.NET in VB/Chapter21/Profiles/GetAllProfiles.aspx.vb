
Partial Class GetAllProfiles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridProfiles.DataSource = ProfileManager.GetAllProfiles(ProfileAuthenticationOption.Authenticated)
        gridProfiles.DataBind()
    End Sub

End Class
