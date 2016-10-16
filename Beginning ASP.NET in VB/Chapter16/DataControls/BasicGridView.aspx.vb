Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class BasicGridView
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Define the ADO.NET objects.
        Dim connectionString As String = _
          WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
        Dim selectSQL As String = _
          "SELECT ProductID, ProductName, UnitPrice FROM Products"
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(selectSQL, con)
        Dim adapter As New SqlDataAdapter(cmd)

        ' Fill the DataSet
        Dim ds As New DataSet()
        adapter.Fill(ds, "Products")

        ' Perform the binding.
        GridView1.DataSource = ds
        GridView1.DataBind()

    End Sub
End Class
