Imports Components

Partial Class TestPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim testComponent As New SimpleTest()
        Dim testComponent2 As New SimpleTest2()
        lblResult.Text = testComponent.GetInfo("Hello") & "<br><br>"
        lblResult.Text &= testComponent2.GetInfo("Bye")
    End Sub
End Class
