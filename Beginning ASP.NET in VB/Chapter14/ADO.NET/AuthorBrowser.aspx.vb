Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class AuthorBrowser
    Inherits System.Web.UI.Page

    Private connectionString As String = _
     WebConfigurationManager.ConnectionStrings("Pubs").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            FillAuthorList()
        End If
    End Sub

    Private Sub FillAuthorList()
        lstAuthor.Items.Clear()

        ' Define the Select statement.
        ' Three pieces of information are needed: the unique id
        ' and the first and last name.
        Dim selectSQL As String = "SELECT au_lname, au_fname, au_id FROM Authors"

        ' Define the ADO.NET objects.
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(selectSQL, con)
        Dim reader As SqlDataReader

        ' Try to open database and read information.
        Try
            con.Open()
            reader = cmd.ExecuteReader()

            ' For each item, add the author name to the displayed
            ' list box text, and store the unique ID in the Value property.
            Do While reader.Read()
                Dim newItem As New ListItem()
                newItem.Text = reader("au_lname") & ", " & reader("au_fname")
                newItem.Value = reader("au_id").ToString()
                lstAuthor.Items.Add(newItem)
            Loop
            reader.Close()

        Catch Err As Exception
            lblResults.Text = "Error reading list of names. "
            lblResults.Text &= err.Message
        Finally
            con.Close()
        End Try
    End Sub

    Protected Sub lstAuthor_SelectedIndexChanged(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles lstAuthor.SelectedIndexChanged

        ' Create a Select statement that searches for a record
        ' matching the specific author ID from the Value property.
        Dim selectSQL As String
        selectSQL = "SELECT * FROM Authors "
        selectSQL &= "WHERE au_id='" & lstAuthor.SelectedItem.Value & "'"

        ' Define the ADO.NET objects.
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(selectSQL, con)
        Dim reader As SqlDataReader

        ' Try to open database and read information.
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()

            ' Build a string with the record information,
            ' and display that in a label.
            Dim sb As New StringBuilder()
            sb.Append("<b>")
            sb.Append(reader("au_lname"))
            sb.Append(", ")
            sb.Append(reader("au_fname"))
            sb.Append("</b><br />")
            sb.Append("Phone: ")
            sb.Append(reader("phone"))
            sb.Append("<br />")
            sb.Append("Address: ")
            sb.Append(reader("address"))
            sb.Append("<br />")
            sb.Append("City: ")
            sb.Append(reader("city"))
            sb.Append("<br />")
            sb.Append("State: ")
            sb.Append(reader("state"))
            sb.Append("<br />")
            lblResults.Text = sb.ToString()

            reader.Close()

        Catch Err As Exception
            lblResults.Text = "Error getting author. "
            lblResults.Text &= err.Message
        Finally
            con.Close()
        End Try
    End Sub


   
End Class
