
Partial Class RecordEditorDataSource_MatchAllValues
    Inherits System.Web.UI.Page

    Protected Sub sourceProductDetails_Updated(ByVal sender As Object, _
  ByVal e As SqlDataSourceStatusEventArgs) Handles sourceProductDetails.Updated

        If e.AffectedRows = 0 Then
            lblInfo.Text = "No update was performed. " & _
              "A concurrency error is likely, or the command is incorrectly written."
        Else
            lblInfo.Text = "Record successfully updated."
        End If
    End Sub

End Class
