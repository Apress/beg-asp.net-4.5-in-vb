
Partial Class QueryStringSender
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
  Handles Me.Load
        If Not Me.IsPostBack Then
            ' Add sample values.
            lstItems.Items.Add("Econo Sofa")
            lstItems.Items.Add("Supreme Leather Drapery")
            lstItems.Items.Add("Threadbare Carpet")
            lstItems.Items.Add("Antique Lamp")
            lstItems.Items.Add("Retro-Finish Jacuzzi")
        End If
    End Sub

    Protected Sub cmdGo_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdGo.Click
        If lstItems.SelectedIndex = -1 Then
            lblError.Text = "You must select an item."
        Else
            ' Forward the user to the information page,
            ' with the query string data.
            Dim Url As String = "QueryStringRecipient.aspx?"
            Url &= "Item=" & Server.UrlEncode(lstItems.SelectedItem.Text) & "&"
            Url &= "Mode=" & chkDetails.Checked.ToString()
            Response.Redirect(Url)
        End If
    End Sub

End Class
