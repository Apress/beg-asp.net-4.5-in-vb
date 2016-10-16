Imports Microsoft.VisualBasic

Public Class Employee

    Public Property EmployeeID() As Integer
    Public Property FirstName() As String
    Public Property LastName() As String
    Public Property TitleOfCourtesy() As String

    Public Sub New(ByVal employeeID As Integer, ByVal firstName As String, ByVal lastName As String, ByVal titleOfCourtesy As String)
        Me.EmployeeID = employeeID
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.TitleOfCourtesy = titleOfCourtesy
    End Sub

    Public Shared Function GetEmployees() As List(Of Employee)
        Dim employees As New List(Of Employee)()
        employees.Add(New Employee(1, "Nancy", "Davolio", "Ms."))
        employees.Add(New Employee(2, "Andrew", "Fuller", "Dr."))
        employees.Add(New Employee(3, "Janet", "Leverling", "Ms."))
        employees.Add(New Employee(4, "Margaret", "Peacock", "Mrs."))
        employees.Add(New Employee(5, "Steven", "Buchanan", "Mr."))
        employees.Add(New Employee(6, "Michael", "Suyama", "Mr."))
        employees.Add(New Employee(7, "Robert", "King", "Mr."))
        employees.Add(New Employee(8, "Laura", "Callahan", "Ms."))
        employees.Add(New Employee(9, "Anne", "Dodsworth", "Ms."))
        Return employees
    End Function

End Class
