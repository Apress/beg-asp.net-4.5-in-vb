
Partial Class QueryStringRecipient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
      Handles MyBase.Load
        lblInfo.Text = "Item: " & Request.QueryString("Item")
        lblInfo.Text &= "<br />Show Full Record: "
        lblInfo.Text &= Request.QueryString("Mode")

    End Sub

End Class

