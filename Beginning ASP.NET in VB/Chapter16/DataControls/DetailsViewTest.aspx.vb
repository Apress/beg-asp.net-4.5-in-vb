
Partial Class DetailsViewTest
    Inherits System.Web.UI.Page

    Private insertComplete As Boolean = False

    Protected Sub SqlDataSource1_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles SqlDataSource1.Inserted
        ' Flag that a new record is inserted, which we'll show when the grid is bound.
        If e.AffectedRows > 0 Then insertComplete = True

        ' You could also get output parameters at this point from e.Command.
        ' For example, if you called a stored procedure that returns the newly
        ' generated ProductID value, you could get it here.

    End Sub

    Protected Sub DetailsView1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles DetailsView1.DataBound
        If insertComplete Then
            ' Show the last record (the newly added one).
            DetailsView1.PageIndex = DetailsView1.PageCount - 1
        End If
    End Sub
End Class
