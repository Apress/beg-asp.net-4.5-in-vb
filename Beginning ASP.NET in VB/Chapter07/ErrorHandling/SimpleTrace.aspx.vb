
Partial Class SimpleTrace
    Inherits System.Web.UI.Page

    Protected Sub cmdTrace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTrace.Click
        Trace.IsEnabled = True
    End Sub
End Class
