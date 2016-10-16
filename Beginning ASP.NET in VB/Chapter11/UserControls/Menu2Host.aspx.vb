
Partial Class Menu2Host
    Inherits System.Web.UI.Page

   
    Protected Sub Menu1_LinkClicked(ByVal sender As Object, _
  ByVal e As LinkClickedEventArgs) Handles Menu1.LinkClicked
        If e.Url = "Menu2Host.aspx?product=Furniture" Then
            lblClick.Text = "This link is not allowed."
            e.Cancel = True
        Else
            ' Allow the redirect, and don't make any changes to the URL.
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Request.Params("product") IsNot Nothing Then
                lblSelection.Text = "You chose: "
                lblSelection.Text &= Request.Params("product")
            End If
        End If
    End Sub
End Class
