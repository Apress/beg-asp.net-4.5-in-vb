
Partial Class ComplexTypes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            LoadProfile()
        End If
    End Sub

    Protected Sub cmdGet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        LoadProfile()
    End Sub

    Private Sub LoadProfile()
        txtName.Text = Profile.Address.Name
        txtStreet.Text = Profile.Address.Street
        txtCity.Text = Profile.Address.City
        txtZip.Text = Profile.Address.ZipCode
        txtState.Text = Profile.Address.State
        txtCountry.Text = Profile.Address.Country
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Profile.Address = New Address(txtName.Text, _
          txtStreet.Text, txtCity.Text, txtZip.Text, _
          txtState.Text, txtCountry.Text)
    End Sub
End Class
