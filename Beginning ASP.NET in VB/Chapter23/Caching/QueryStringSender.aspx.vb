
Partial Class QueryStringSender
    Inherits System.Web.UI.Page


    Protected Sub cmdNormal_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) _
      Handles cmdNormal.Click, cmdLarge.Click, cmdSmall.Click

        Response.Redirect("QueryStringRecipient.aspx" & _
          "?Version=" & CType(sender, Control).ID)
    End Sub

End Class
