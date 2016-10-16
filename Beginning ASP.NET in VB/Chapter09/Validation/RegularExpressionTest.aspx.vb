
Partial Class RegularExpressionTest
    Inherits System.Web.UI.Page

    Protected Sub cmdSetExpression_Click(ByVal sender As Object, _
    ByVal e As EventArgs) Handles cmdSetExpression.Click
        TestValidator.ValidationExpression = txtExpression.Text
        lblExpression.Text = "Current Expression: "
        lblExpression.Text &= txtExpression.Text
    End Sub

End Class
