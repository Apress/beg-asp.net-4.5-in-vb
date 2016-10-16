
Partial Class CustomParameters
    Inherits System.Web.UI.Page
    Protected Sub sourceOrders_Selecting(ByVal sender As Object, _
      ByVal e As SqlDataSourceSelectingEventArgs) Handles sourceOrders.Selecting

        e.Command.Parameters("@EarliestOrderDate").Value = _
          DateTime.Today.AddYears(-10)
    End Sub

End Class
