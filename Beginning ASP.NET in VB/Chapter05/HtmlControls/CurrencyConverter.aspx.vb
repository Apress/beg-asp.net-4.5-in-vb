
Partial Class CurrencyConverter
    Inherits System.Web.UI.Page

    Protected Sub Convert_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Convert.ServerClick
        Dim oldAmount As Double = Val(US.Value)

        If oldAmount <= 0 Then
            Result.Style("color") = "Red"
            Result.InnerText = "Specify a positive number"
        Else
            Result.Style("color") = "Black"

            ' Retrieve the selected ListItem object by its index number.
            Dim item As ListItem = Currency.Items(Currency.SelectedIndex)

            Dim newAmount As Double = oldAmount * Val(item.Value)
            Result.InnerText = oldAmount.ToString() & " U.S. dollars = "
            Result.InnerText &= newAmount.ToString() & " " & item.Text

            Graph.Src = "pic" & Currency.SelectedIndex.ToString() & ".png"
        End If

    End Sub

    Protected Sub ShowGraph_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowGraph.ServerClick
        Graph.Src = "Pic" & Currency.SelectedIndex.ToString() & ".png"
        Graph.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack = False Then
            ' The HtmlSelect control accepts text or ListItem objects.
            Currency.Items.Add(New ListItem("Euros", "0.85"))
            Currency.Items.Add(New ListItem("Japanese Yen", "110.33"))
            Currency.Items.Add(New ListItem("Canadian Dollars", "1.2"))
            Graph.Visible = False
        End If
    End Sub
End Class
