Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class MultipleViews
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Cache.Remove("Titles")

            Dim ds As DataSet = GetDataSet()

            chkColumns.DataSource = ds.Tables("Customers").Columns
            chkColumns.DataTextField = "ColumnName"
            chkColumns.DataBind()
        End If
    End Sub

    ' This method checks the cache for the DataSet,
    ' and re-caches it if needed.
    Private Function GetDataSet() As DataSet
        Dim ds As DataSet = CType(Cache("Customers"), DataSet)

        ' Contact the database if necessary.
        If ds Is Nothing Then
            ds = RetrieveData()
            Cache.Insert("Customers", ds, Nothing, DateTime.MaxValue, TimeSpan.FromMinutes(2))
            lblCacheStatus.Text = "Created and added to cache."
        Else
            lblCacheStatus.Text = "Retrieved from cache."
        End If

        Return ds
    End Function

    ' This method performs the database query, if the 
    ' DataSet object isn't available in the cache.
    Private Function RetrieveData() As DataSet
        Dim connectionString As String = _
          WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
        Dim SQLSelect As String = "SELECT * FROM Customers"
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(SQLSelect, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()

        Try
            con.Open()
            adapter.Fill(ds, "Customers")
        Finally
            con.Close()
        End Try

        Return ds
    End Function

    Protected Sub cmdFilter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        Dim ds As DataSet = GetDataSet()

        ' Copy the DataSet so the cached item isn't affected
        ' when we remove columns.
        ds = ds.Copy()

        For Each item As ListItem In chkColumns.Items
            If item.Selected Then
                ds.Tables("Customers").Columns.Remove(item.Text)
            End If
        Next

        gridCustomers.DataSource = ds.Tables("Customers")
        gridCustomers.DataBind()

    End Sub
End Class
