
Partial Class Cookieless1
    Inherits System.Web.UI.Page

    Protected Sub cmdLink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLink.Click
        Response.Redirect("Cookieless2.aspx")
    End Sub

    Protected Sub cmdLinkAbsolute_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLinkAbsolute.Click
        ' Create a new URL based on the current URL (but ending with
        ' the page Cookieless2.aspx instead of Cookieless1.aspx.
        Dim url As String = "http://" & Request.Url.Authority & _
         Request.Url.Segments(0) & "Cookieless2.aspx"
        Response.Redirect(url)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("test") = "Test String"
    End Sub
End Class
