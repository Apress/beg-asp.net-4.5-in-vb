
Partial Class SimpleDataCache
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack Then
            lblInfo.Text &= "Page posted back.<br />"
        Else
            lblInfo.Text &= "Page created.<br />"
        End If

        If Cache("TestItem") Is Nothing Then
            lblInfo.Text &= "Creating TestItem...<br />"
            Dim testItem As DateTime = DateTime.Now

            lblInfo.Text &= "Storing TestItem in cache "
            lblInfo.Text &= "for 30 seconds.<br />"
            Cache.Insert("TestItem", testItem, Nothing, _
              DateTime.Now.AddSeconds(30), TimeSpan.Zero)
        Else
            lblInfo.Text &= "Retrieving TestItem...<br />"
            Dim testItem As DateTime = CType(Cache("TestItem"), DateTime)
            lblInfo.Text &= "TestItem is '" & testItem.ToString()
            lblInfo.Text &= "'<br />"
        End If

        lblInfo.Text &= "<br />"
    End Sub

End Class
