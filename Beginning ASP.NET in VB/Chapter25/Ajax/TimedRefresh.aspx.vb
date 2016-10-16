
Partial Class TimedRefresh
    Inherits System.Web.UI.Page

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) _
  Handles Timer1.Tick

        ' Update the tick count and store it in view state.
        Dim tickCount As Integer = 0
        If ViewState("TickCount") IsNot Nothing Then
            tickCount = CType(ViewState("TickCount"), Integer)
        End If

        tickCount += 1
        ViewState("TickCount") = tickCount

        ' Decide whether to disable the timer.
        If tickCount > 10 Then
            Timer1.Enabled = False
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class
