
Partial Class SimpleCounter
    Inherits System.Web.UI.Page

    Protected Sub cmdIncrement_Click(ByVal sender As Object, _
    ByVal e As EventArgs) Handles cmdIncrement.Click
        Dim Counter As Integer
        If ViewState("Counter") Is Nothing Then
            Counter = 1
        Else
            Counter = CType(ViewState("Counter"), Integer) + 1
        End If

        ViewState("Counter") = Counter
        lblCount.Text = "Counter: " & Counter.ToString()
    End Sub

End Class
