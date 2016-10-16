Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class Sql2005Dependency
    Inherits System.Web.UI.Page

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        lblInfo.Text &= "<br />"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            'SqlDependency.Stop(connectionString);
            ' Must be called at least once for application to set
            ' up listener.
            SqlDependency.Start(connectionString)

            lblInfo.Text &= "Creating dependent item...<br />"
            Cache.Remove("Customers")

            Dim dt As DataTable = GetTable()
            lblInfo.Text &= "Adding dependent item<br />"
            Cache.Insert("Customers", dt, dependency)
        End If
    End Sub

    Private dependency As SqlCacheDependency
    Private connectionString As String = _
  WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
    Private Function GetTable() As DataTable

        Dim con As New SqlConnection(connectionString)
        Dim sql As String = "SELECT ContactName FROM dbo.Customers"
        Dim da As New SqlDataAdapter(sql, con)

        ' Create a dependency for the Employees table.
        dependency = New SqlCacheDependency(da.SelectCommand)

        Dim ds As New DataSet()
        da.Fill(ds, "Customers")
        Return ds.Tables(0)

    End Function

    Protected Sub cmdGetItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGetItem.Click
        If Cache("Customers") Is Nothing Then
            lblInfo.Text &= "Cache item no longer exits.<br />"
        Else
            lblInfo.Text &= "Item is still present.<br />"
        End If
    End Sub

    Protected Sub cmdModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim con As New SqlConnection(connectionString)
        ' Even a change that really does do anything is still a change.
        Dim sql As String = "UPDATE dbo.Customers SET ContactName='Maria Anders' WHERE CustomerID='ALFKI'"
        Dim cmd As New SqlCommand(sql, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try

        lblInfo.Text &= "Update completed (no need to wait, because polling is not used).<br />"

    End Sub
End Class
