Imports System.IO

Partial Class DynamicThemes
    Inherits System.Web.UI.Page

    Protected Sub cmdApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        ' Set the chosen theme.
        Session("Theme") = lstThemes.SelectedValue

        ' Refresh the page.
        Server.Transfer(Request.FilePath)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then

            ' Fill the list box with available themes
            ' by reading the folders in the App_Themes folder.
            Dim themeDir As New DirectoryInfo(Server.MapPath("App_Themes"))
            lstThemes.DataTextField = "Name"
            lstThemes.DataSource = themeDir.GetDirectories()
            lstThemes.DataBind()
        End If
    End Sub

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
        If Session("Theme") Is Nothing Then

            ' No theme has been chosen. Choose a default
            ' (or set a blank string to make sure no theme
            ' is used).
            Page.Theme = ""
        Else
            Page.Theme = CType(Session("Theme"), String)
        End If
    End Sub

    Protected Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        ' Clear the chosen theme.
        Session("Theme") = ""

        ' Refresh the page.
        Server.Transfer(Request.FilePath)
    End Sub
End Class
