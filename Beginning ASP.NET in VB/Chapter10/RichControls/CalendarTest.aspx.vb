
Partial Class CalendarTest
    Inherits System.Web.UI.Page

    Protected Sub MyCalendar_MyDayRender(ByVal source As Object, ByVal e As DayRenderEventArgs) _
  Handles MyCalendar.DayRender

        ' Check for May 5 in any year, and format it.
        If e.Day.Date.Day = 5 And e.Day.Date.Month = 5 Then
            e.Cell.BackColor = System.Drawing.Color.Yellow

            ' Add some static text to the cell.
            Dim lbl As New Label
            lbl.Text = "<br>My Birthday!"
            e.Cell.Controls.Add(lbl)
        End If
    End Sub

    Protected Sub MyCalendar_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyCalendar.SelectionChanged
        lblDates.Text = "You selected these dates:<br>"

        Dim dt As DateTime
        For Each dt In MyCalendar.SelectedDates
            lblDates.Text &= dt.ToLongDateString() & "<br />"
        Next

    End Sub
End Class
