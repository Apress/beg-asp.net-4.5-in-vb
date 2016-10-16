Imports NorthwindModel

Partial Class EntityModelRelationships
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim entities As New NorthwindEntities()

        ' Build a string full of HTML markup.
        Dim sb As New StringBuilder()
        For Each customer As Customer In entities.Customers.Include("Orders.Order_Details.Product")
            ' Write out the customer information in bold.
            sb.Append("<b>")
            sb.Append(customer.CompanyName)
            sb.Append("</b><br />")

            ' List this customer's orders.
            For Each order As Order In customer.Orders
                sb.Append(order.OrderID.ToString())
                sb.Append(" - made on date: ")
                sb.Append(order.OrderDate.Value.ToShortDateString())
                sb.Append("<br />")

                sb.Append("&nbsp;&nbsp;Products: ")
                sb.Append("<ul>")
                For Each orderDetail As Order_Detail In order.Order_Details
                    sb.Append("<li>" & orderDetail.Product.ProductName & "</li>")
                Next
                sb.Append("</ul><br />")
            Next
            ' Add a horizontal line.
            sb.Append("<hr /><br />")
        Next

        ' Show the HTML in a Label control.
        lblData.Text = sb.ToString()

    End Sub
End Class
