
Partial Class QueryStringRecipient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDate.Text = "The time is now:<br />" & DateTime.Now.ToString()

        Select Case Request.QueryString("Version")
            Case "cmdLarge"
                lblDate.Font.Size = FontUnit.XLarge
            Case "cmdNormal"
                lblDate.Font.Size = FontUnit.Large
            Case "cmdSmall"
                lblDate.Font.Size = FontUnit.Small
        End Select

    End Sub
End Class
