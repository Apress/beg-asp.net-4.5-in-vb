
Partial Class FormatHighPrices
    Inherits System.Web.UI.Page

    Protected Sub GridView1_RowDataBound(ByVal sender As Object, _
    ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) _
    Handles GridView1.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' Get the price for this row.
            Dim price As Decimal
            price = CType(DataBinder.Eval(e.Row.DataItem, "UnitPrice"), Decimal)

            If price > 50 Then
                e.Row.BackColor = System.Drawing.Color.Maroon
                e.Row.ForeColor = System.Drawing.Color.White
                e.Row.Font.Bold = True
            End If
        End If
    End Sub

End Class
