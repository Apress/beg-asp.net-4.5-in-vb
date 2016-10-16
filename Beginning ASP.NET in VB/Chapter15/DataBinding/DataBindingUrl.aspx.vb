
Partial Class DataBindingUrl
    Inherits System.Web.UI.Page

    Protected URL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        URL = "Images/picture.jpg"
        Me.DataBind()
    End Sub
End Class
