
Partial Class HtmlEncodeTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ctrl1.InnerHtml = "To <b>bold</b> text use the <b> tag."
        ctrl2.InnerHtml = "To <b>bold</b> text use the " + Server.HtmlEncode("<b>") + " tag."

    End Sub
End Class
