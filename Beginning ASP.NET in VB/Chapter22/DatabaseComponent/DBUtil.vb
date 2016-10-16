Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Public Class DBUtil
    Private connectionString As String

    Public Sub New()
        If WebConfigurationManager.ConnectionStrings("AdBoard") _
          Is Nothing Then
            Throw New ApplicationException( _
              "Missing ConnectionString variable in web.config.")
        Else
            connectionString = _
              WebConfigurationManager.ConnectionStrings( _
              "AdBoard").ConnectionString
        End If
    End Sub

    Public Function GetCategories() As DataSet
        Dim query As String = "SELECT * FROM Categories"
        Dim cmd As New SqlCommand(query)
        Return FillDataSet(cmd, "Categories")
    End Function

    Public Function GetItems() As DataSet
        Dim query As String = "SELECT * FROM Items"
        Dim cmd As New SqlCommand(query)
        Return FillDataSet(cmd, "Items")
    End Function

    Public Function GetItems(ByVal categoryID As Integer) As DataSet
        ' Create the Command.
        Dim query As String = "SELECT * FROM Items WHERE Category_ID=@CategoryID"
        Dim cmd As New SqlCommand(query)
        cmd.Parameters.AddWithValue("@CategoryID", categoryID)

        ' Fill the DataSet.
        Return FillDataSet(cmd, "Items")
    End Function

    Public Sub AddCategory(ByVal name As String)
        Dim con As New SqlConnection(connectionString)

        ' Create the Command.
        Dim insertSQL As String = "INSERT INTO Categories "
        insertSQL &= "(Name) VALUES @Name"
        Dim cmd As New SqlCommand(insertSQL, con)
        cmd.Parameters.AddWithValue("@Name", name)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub AddItem(ByVal title As String, ByVal description As String, _
    ByVal price As Decimal, ByVal categoryID As Integer)
        Dim con As New SqlConnection(connectionString)

        ' Create the Command.
        Dim insertSQL As String = "INSERT INTO Items "
        insertSQL &= "(Title, Description, Price, Category_ID)"
        insertSQL &= "VALUES (@Title, @Description, @Price, @CategoryID)"
        Dim cmd As New SqlCommand(insertSQL, con)
        cmd.Parameters.AddWithValue("@Title", title)
        cmd.Parameters.AddWithValue("@Description", description)
        cmd.Parameters.AddWithValue("@Price", price)
        cmd.Parameters.AddWithValue("@CategoryID", categoryID)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try
    End Sub

    Private Function FillDataSet(ByVal cmd As SqlCommand, ByVal tableName As String) _
      As DataSet
        Dim con As New SqlConnection(connectionString)
        cmd.Connection = con
        Dim adapter As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()
        Try
            con.Open()
            adapter.Fill(ds, tableName)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function GetAveragePrice() As Decimal
        Dim query As String = "SELECT AVG(Price) FROM Items"

        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(query, con)

        con.Open()
        Dim average As Decimal = CType(cmd.ExecuteScalar(), Decimal)
        con.Close()

        Return average
    End Function

    Public Function GetTotalItems() As Integer
        Dim query As String = "SELECT Count(*) FROM Items"

        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(query, con)

        con.Open()
        Dim count As Integer = CType(cmd.ExecuteScalar(), Integer)
        con.Close()

        Return count
    End Function

End Class

