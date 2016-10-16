Imports NorthwindModel

Partial Class UpdateInsertDelete
    Inherits System.Web.UI.Page

    Private entities As New NorthwindEntities()

    Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cmdUpdate.Click

        ' Only allow updating if a record is currently selected.
        If gridProducts.SelectedIndex <> -1 Then
            ' Use a LINQ expression to find the selected product.
            Dim selectedProductID As Integer = Val(gridProducts.SelectedDataKey.Value)
            Dim matches = From p In entities.Products
                          Where p.ProductID = selectedProductID
                          Select p

            ' Execute the query and return the entity object.
            Dim product As Product = matches.Single()

            ' Change the entity object.
            product.UnitsInStock -= 1

            ' Commit the changes back to the database.
            entities.SaveChanges()
        End If

    End Sub

    Protected Sub cmdInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cmdInsert.Click

        ' The CreateProduct() method requires the three non-nullable Product fields
        ' as arguments: ProductID, ProductName, and Discontinued. However, the
        ' ProductName isn't actually used--when the update is finsihed, it's replaced
        ' by the automatically generated ID that the database creates.
        Dim newProduct As Product
        newProduct = Product.CreateProduct(0, "Thick-As-Cement Milkshake", False)

        ' You can now set additional properties that aren't required.
        newProduct.CategoryID = 1
        newProduct.UnitsInStock = 10
        newProduct.UnitPrice = 15.99D

        ' Finally, commit the changes and insert the record in the database.
        entities.Products.AddObject(newProduct)
        entities.SaveChanges()

    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cmdDelete.Click

        ' Check if a row is selected.
        If gridProducts.SelectedIndex <> -1 Then
            ' Use a LINQ expression to find the selected product.
            Dim selectedProductID As Integer = Val(gridProducts.SelectedDataKey.Value)
            Dim matches = From p In entities.Products
                          Where p.ProductID = selectedProductID
                          Select p

            ' Execute the query and return the entity object.
            Dim product As Product = matches.Single()

            ' Delete the record from the database.
            entities.Products.DeleteObject(product)
            entities.SaveChanges()

            ' Clear the selection (which may now be pointing to a different row.)
            gridProducts.SelectedIndex = -1
        End If
    End Sub

    ' Update grid just before page is rendered, so it includes the most
    ' recent changes.
    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        gridProducts.DataSource = entities.Products
        gridProducts.DataBind()
    End Sub

End Class
