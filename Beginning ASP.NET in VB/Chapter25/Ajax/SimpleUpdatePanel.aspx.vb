
Partial Class SimpleUpdatePanel
    Inherits System.Web.UI.Page

    Protected Sub cmdRefreshTime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRefreshTime.Click
        lblTime.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack Then
            Throw New ApplicationException("This operation failed.")
            ' The debugger will pause when you hit this error.
            ' Press Continue to keep going and see the result of the error.
        End If
    End Sub
End Class
