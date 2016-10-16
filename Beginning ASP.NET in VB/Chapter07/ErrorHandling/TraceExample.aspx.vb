
Partial Class TraceExample
    Inherits System.Web.UI.Page

    Protected Sub cmdWrite_Click(ByVal sender As Object, ByVal e As EventArgs) _
    Handles cmdWrite.Click

        Trace.Write("About to place an item in session state.")
        Session("Test") = "Contents"
        Trace.Write("Placed item in session state.")
    End Sub

    Protected Sub cmdWriteCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles cmdWriteCategory.Click

        Trace.Write("cmdWriteCategory_Click", "About to place an item in session state.")
        Session("Test") = "Contents"
        Trace.Write("cmdWriteCategory_Click", "Placed item in session state.")
    End Sub

    Protected Sub cmdError_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdError.Click

        Try
            DivideNumbers(5, 0)
        Catch err As Exception
            Trace.Warn("cmdError_Click", "Caught Error", err)
        End Try
    End Sub

    Private Function DivideNumbers(ByVal number As Integer, ByVal divisor As Integer) As Decimal
        Return number / divisor
    End Function

End Class
