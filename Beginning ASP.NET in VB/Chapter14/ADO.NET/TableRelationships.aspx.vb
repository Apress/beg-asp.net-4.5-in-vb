Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class TableRelationships
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            CreateList()
        End If
    End Sub

    Private connectionString As String = _
  WebConfigurationManager.ConnectionStrings("Pubs").ConnectionString

    Private Sub CreateList()
        ' Define ADO.NET objects.
        Dim selectSQL As String = "SELECT au_lname, au_fname, au_id FROM Authors"
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(selectSQL, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dsPubs As New DataSet()

        Try
            con.Open()
            adapter.Fill(dsPubs, "Authors")

            ' This command is still linked to the data adapter.
            cmd.CommandText = "SELECT au_id, title_id FROM TitleAuthor"
            adapter.Fill(dsPubs, "TitleAuthor")

            ' This command is still linked to the data adapter.
            cmd.CommandText = "SELECT title_id, title FROM Titles"
            adapter.Fill(dsPubs, "Titles")

        Catch err As Exception
            lblList.Text = "Error reading list of names. "
            lblList.Text &= err.Message
        Finally
            con.Close()
        End Try

        Dim Titles_TitleAuthor As New DataRelation("Titles_TitleAuthor", _
  dsPubs.Tables("Titles").Columns("title_id"), _
  dsPubs.Tables("TitleAuthor").Columns("title_id"))
        Dim Authors_TitleAuthor As New DataRelation("Authors_TitleAuthor", _
          dsPubs.Tables("Authors").Columns("au_id"), _
          dsPubs.Tables("TitleAuthor").Columns("au_id"))

        dsPubs.Relations.Add(Titles_TitleAuthor)
        dsPubs.Relations.Add(Authors_TitleAuthor)

        For Each rowAuthor As DataRow In dsPubs.Tables("Authors").Rows

            lblList.Text &= "<br /><b>" & rowAuthor("au_fname")
            lblList.Text &= " " & rowAuthor("au_lname") & "</b><br />"

            For Each rowTitleAuthor As DataRow In _
             rowAuthor.GetChildRows(Authors_TitleAuthor)

                Dim rowTitle As DataRow = _
                 rowTitleAuthor.GetParentRows(Titles_TitleAuthor)(0)

                lblList.Text &= "&nbsp;&nbsp;"
                lblList.Text &= rowTitle("title") & "<br />"
            Next
        Next

    End Sub
End Class
