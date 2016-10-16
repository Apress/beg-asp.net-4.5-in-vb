
Partial Class GetProfile
    Inherits System.Web.UI.Page

    Protected Sub cmdGet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        Dim currentProfile As ProfileCommon = Profile.GetProfile(txtUserName.Text)
        If Profile.LastUpdatedDate = DateTime.MinValue Then
            lbl.Text = "No user match found."
        Else
            lbl.Text = "This user lives in " & currentProfile.Address.Country
        End If

    End Sub
End Class
