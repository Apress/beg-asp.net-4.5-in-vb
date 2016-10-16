
Partial Class SimpleTypes
    Inherits System.Web.UI.Page

    Protected Sub cmdShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdShow.Click
        lbl.Text = "First Name: " & Profile.FirstName & "<br />" & _
          "Last Name: " & Profile.LastName & "<br />" & _
          "Date of Birth: " & Profile.DateOfBirth.ToString()
    End Sub

    Protected Sub cmdSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSet.Click
        Profile.FirstName = txtFirst.Text
        Profile.LastName = txtLast.Text
        Profile.DateOfBirth = Calendar1.SelectedDate
    End Sub
End Class
