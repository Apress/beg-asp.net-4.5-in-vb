Imports System.Data

Partial Class DataSetBinding
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Define a DataSet with a single DataTable.
        Dim dsInternal As New DataSet()
        dsInternal.Tables.Add("Users")

        ' Define two columns for this table.
        dsInternal.Tables("Users").Columns.Add("Name")
        dsInternal.Tables("Users").Columns.Add("Country")

        ' Add some actual information into the table.
        Dim rowNew As DataRow = dsInternal.Tables("Users").NewRow()
        rowNew("Name") = "John"
        rowNew("Country") = "Uganda"
        dsInternal.Tables("Users").Rows.Add(rowNew)

        rowNew = dsInternal.Tables("Users").NewRow()
        rowNew("Name") = "Samantha"
        rowNew("Country") = "Belgium"
        dsInternal.Tables("Users").Rows.Add(rowNew)

        rowNew = dsInternal.Tables("Users").NewRow()
        rowNew("Name") = "Rico"
        rowNew("Country") = "Japan"
        dsInternal.Tables("Users").Rows.Add(rowNew)

        ' Define the binding.
        lstUser.DataSource = dsInternal.Tables("Users")
        lstUser.DataTextField = "Name"
        Me.DataBind()

    End Sub
End Class
