Imports System.Web.Configuration

Partial Class ShowSettings
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Result.InnerHtml = "This app will look for data in the directory:<br /><b>"
        Result.InnerHtml &= WebConfigurationManager.AppSettings("DataFilePath")
        Result.InnerHtml &= "</b>"
    End Sub
End Class
