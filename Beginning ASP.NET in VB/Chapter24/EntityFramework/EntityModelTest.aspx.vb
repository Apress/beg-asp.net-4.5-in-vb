Imports NorthwindModel

Partial Class EntityModelTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim entities As New NorthwindEntities()
        GridView1.DataSource = entities.Products

        ' If the database isn't accesible, an exception occurs here (on the next line).
        GridView1.DataBind()
    End Sub
End Class
