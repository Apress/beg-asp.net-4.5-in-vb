
Partial Class Appointment
    Inherits System.Web.UI.Page

    Protected Sub MyCalendar_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyCalendar.SelectionChanged
        lstTimes.Items.Clear()

        Select Case MyCalendar.SelectedDate.DayOfWeek
            Case DayOfWeek.Monday
                ' Apply special Monday schedule.
                lstTimes.Items.Add("10:00")
                lstTimes.Items.Add("10:30")
                lstTimes.Items.Add("11:00")
            Case Else
                lstTimes.Items.Add("10:00")
                lstTimes.Items.Add("10:30")
                lstTimes.Items.Add("11:00")
                lstTimes.Items.Add("11:30")
                lstTimes.Items.Add("12:00")
                lstTimes.Items.Add("12:30")
        End Select

    End Sub

    Protected Sub MyCalendar_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles MyCalendar.DayRender
        
        ' Restrict dates after the year 2012, and those on the weekend.
        If e.Day.IsWeekend Or e.Day.Date.Year > 2012 Then

            e.Day.IsSelectable = False
        End If
    End Sub
End Class
