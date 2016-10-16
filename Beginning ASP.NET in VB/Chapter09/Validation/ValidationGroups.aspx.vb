
Partial Class ValidationGroups
    Inherits System.Web.UI.Page


    Protected Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click
        If Page.IsValid Then
            lblInfo.Text = "Page posted back at " & DateTime.Now.ToLongTimeString()
        End If
    End Sub
End Class
