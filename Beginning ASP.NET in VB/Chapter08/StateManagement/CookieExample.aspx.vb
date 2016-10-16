
Partial Class CookieExample
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
      Handles MyBase.Load
        Dim Cookie As HttpCookie = Request.Cookies("Preferences")
        If Cookie Is Nothing Then
            lblWelcome.Text = "<b>Unknown Customer</b>"
        Else
            lblWelcome.Text = "<b>Cookie Found.</b><br><br>"
            lblWelcome.Text &= "Welcome, " & Cookie("Name")
        End If
    End Sub

    Protected Sub cmdStore_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdStore.Click
        Dim Cookie As HttpCookie = Request.Cookies("Preferences")
        If Cookie Is Nothing Then
            Cookie = New HttpCookie("Preferences")
        End If

        Cookie("Name") = txtName.Text
        Cookie.Expires = DateTime.Now.AddYears(1)
        Response.Cookies.Add(Cookie)

        lblWelcome.Text = "<b>Cookie Created.</b><br><br>"
        lblWelcome.Text &= "New Customer: " & Cookie("Name")
    End Sub

End Class
