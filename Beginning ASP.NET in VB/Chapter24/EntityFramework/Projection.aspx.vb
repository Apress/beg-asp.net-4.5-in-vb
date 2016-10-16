
Partial Class Projection
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Get the full collection of employees from a helper method.
        Dim employees As List(Of Employee) = Employee.GetEmployees()

        ' Anonymous type.
        Dim matches = From employee In employees
                      Select New With
                      {.First = employee.FirstName, .Last = employee.LastName}

        gridEmployees.DataSource = matches
        gridEmployees.DataBind()
    End Sub
End Class
