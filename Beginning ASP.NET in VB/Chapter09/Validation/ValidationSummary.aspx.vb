
Partial Class ValidationSummary
    Inherits System.Web.UI.Page

    Protected Sub cmdOK_Click(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles cmdOK.Click

        ' Abort the event if the control isn't valid.
        If Not Page.IsValid Then Return

        lblMessage.Text = "cmdOK_Click event handler executed."
    End Sub
End Class
