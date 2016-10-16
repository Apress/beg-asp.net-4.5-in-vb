
Partial Class CustomerForm
    Inherits System.Web.UI.Page

    Protected Sub cmdSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdSubmit.Click
        If Page.IsValid = False Then Exit Sub
        lblMessage.Text = "This is a valid form."
    End Sub

    Protected Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdCancel.Click
        lblMessage.Text = "No attempt was made to validate this form."
    End Sub

    Protected Sub vldCode_ServerValidate(ByVal source As Object, _
    ByVal e As ServerValidateEventArgs) Handles vldCode.ServerValidate

        ' Check if the first three digits are divisible by seven.
        If Val(e.Value) <> 0 And Val(e.Value.Substring(0, 3)) Mod 7 = 0 Then
            e.IsValid = True
        Else
            e.IsValid = False
        End If
    End Sub

End Class
