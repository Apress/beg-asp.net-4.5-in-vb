
Partial Class product1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If SiteMap.CurrentNode.NextSibling IsNot Nothing Then
            lnkNext.NavigateUrl = SiteMap.CurrentNode.NextSibling.Url
            lnkNext.Visible = True
        Else
            lnkNext.Visible = False
        End If

    End Sub
End Class
