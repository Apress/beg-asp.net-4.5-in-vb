
Partial Class ErrorPage
    Inherits System.Web.UI.Page

    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim url As String = Request.QueryString("aspxerrorpath")
        If url <> "" Then Response.Redirect(url)
    End Sub
End Class
