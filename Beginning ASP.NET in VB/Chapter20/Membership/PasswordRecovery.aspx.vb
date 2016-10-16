
Partial Class PasswordRecovery
    Inherits System.Web.UI.Page

    Protected Sub PasswordRecovery1_SendingMail(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MailMessageEventArgs) Handles PasswordRecovery1.SendingMail
        e.Cancel = True
        PasswordRecovery1.SuccessText = e.Message.Body
    End Sub
End Class
