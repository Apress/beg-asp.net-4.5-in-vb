Imports NorthwindModel

Partial Class LinqToEntities
    Inherits System.Web.UI.Page

    Private entities As New NorthwindEntities()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles Me.Load
        If Not Page.IsPostBack Then
            lstCategories.DataTextField = "CategoryName"
            lstCategories.DataValueField = "CategoryID"
            lstCategories.DataSource = entities.Categories
            lstCategories.DataBind()
        End If
    End Sub

    Protected Sub lstCategories_SelectedIndexChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles lstCategories.SelectedIndexChanged
        Dim selectedID As Integer = Val(lstCategories.SelectedValue)
        If selectedID = -1 Then
            ' The "(Select a Category)" item was picked.
            ' Don't show anything.
            gridProducts.DataSource = Nothing
        Else
            ' Query the products in the selected category.
            gridProducts.DataSource = From product In entities.Products
                                      Where product.CategoryID = selectedID
                                      Select New With {
                                          .Name = product.QuantityPerUnit,
                                          .Quantity = product.QuantityPerUnit,
                                          .Stock = product.UnitsInStock}
        End If
        gridProducts.DataBind()
    End Sub

End Class
