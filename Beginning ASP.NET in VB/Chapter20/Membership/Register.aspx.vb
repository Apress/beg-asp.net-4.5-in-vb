
Partial Class Register
    Inherits System.Web.UI.Page

    Protected Sub CreateUserWizard1_CreatedUser(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreateUserWizard1.CreatedUser
        Roles.AddUserToRole(CreateUserWizard1.UserName, "User")
    End Sub

    Protected Sub CreateUserWizard1_FinishButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles CreateUserWizard1.FinishButtonClick
        Dim lbl As Label
        lbl = CType(CreateUserWizard1.CompleteStep.Controls(0).FindControl( _
         "lblSubscriptionList"), Label)

        Dim chk As CheckBox
        chk = CType(CreateUserWizard1.FindControl("chkSubscription"), CheckBox)

        Dim selection As String = ""
        For Each item As ListItem In chkSubscription.Items
            If item.Selected Then
                selection &= "<br />" & item.Text
            End If
        Next
        lbl.Text = selection

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Roles.RoleExists("User") Then
            Roles.CreateRole("User")
        End If
    End Sub
End Class
