
Partial Class PreserveMembers
    Inherits System.Web.UI.Page

    ' A member variable that will be cleared with every postback.
    Private Contents As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
      Handles Me.Load
        If Me.IsPostBack Then
            ' Restore variables.
            Contents = CType(ViewState("Contents"), String)
        End If
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.PreRender
        ' Persist variables.
        ViewState("Contents") = Contents
    End Sub

    Protected Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdSave.Click
        ' Transfer contents of text box to member variable.
        Contents = txtValue.Text
        txtValue.Text = ""
    End Sub

    Protected Sub cmdLoad_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdLoad.Click
        ' Restore contents of member variable to text box.
        txtValue.Text = Contents
    End Sub

End Class
