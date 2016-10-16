
Partial Class CrossPage2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If PreviousPage IsNot Nothing Then
            lblInfo.Text = "You came from a page titled " & _
              PreviousPage.Title & "<br />"

            Dim prevPage As CrossPage1
            prevPage = TryCast(PreviousPage, CrossPage1)
            If prevPage IsNot Nothing Then
                lblInfo.Text &= "You typed in this: " & prevPage.FullName
            End If
        End If
    End Sub
End Class
