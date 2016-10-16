
Partial Class WaitIndicator
    Inherits System.Web.UI.Page

    Protected Sub cmdRefreshTime_Click(ByVal sender As Object, _
  ByVal e As EventArgs) Handles cmdRefreshTime.Click
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10))
        lblTime.Text = DateTime.Now.ToLongTimeString()
    End Sub

End Class
