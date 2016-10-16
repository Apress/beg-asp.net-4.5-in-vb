
Partial Class SimpleDataBinding
    Inherits System.Web.UI.Page

    Protected TransactionCount As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' (You could use database code here
        ' to look up a value for TransactionCount.)
        TransactionCount = 10

        ' Now convert all the data binding expressions on the page.
        Me.DataBind()

    End Sub
End Class
