
Partial Class IterativeVsDeclarative
    Inherits System.Web.UI.Page

    Protected Sub cmdForeach_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdForeach.Click
        ' Get the full collection of employees from a helper method.
        Dim employees As List(Of Employee) = Employee.GetEmployees()

        ' Find the matching employees.
        Dim matches As New List(Of Employee)()
        For Each employee As Employee In employees
            If employee.LastName.StartsWith("D") Then
                matches.Add(employee)
            End If
        Next

        gridEmployees.DataSource = matches
        gridEmployees.DataBind()

    End Sub

    Protected Sub cmdLinq_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLinq.Click
        ' Get the full collection of employees from a helper method.
        Dim employees As List(Of Employee) = Employee.GetEmployees()

        Dim matches = From employee In employees
                      Where employee.LastName.StartsWith("D")
                      Select employee

        gridEmployees.DataSource = matches
        gridEmployees.DataBind()
    End Sub
End Class
