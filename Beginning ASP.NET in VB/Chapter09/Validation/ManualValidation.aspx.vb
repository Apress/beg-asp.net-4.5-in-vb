
Partial Class ManualValidation
    Inherits System.Web.UI.Page


    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles cmdOK.Click

        Dim ErrorMessage As String = "<b>Mistakes found:</b><br />"

        ' Search through the validation controls.
        For Each ctrl As BaseValidator In Me.Validators
            If ctrl.IsValid = False Then
                ErrorMessage &= ctrl.ErrorMessage & "<br />"

                ' Find the corresponding input control, and change the
                ' generic Control variable into a TextBox variable.
                ' This a llows access to the Text property.
                Dim ctrlInput As TextBox
                ctrlInput = CType( _
                  Me.FindControl(ctrl.ControlToValidate), TextBox)
                ErrorMessage &= " * Problem is with this input: "
                ErrorMessage &= ctrlInput.Text & "<br />"
            End If
        Next

        lblMessage.Text = ErrorMessage
    End Sub

End Class
