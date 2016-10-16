Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class AuthorManager
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

            ' Fill the controls.
            txtID.Text = reader("au_id").ToString()
            txtFirstName.Text = reader("au_fname").ToString()
            txtLastName.Text = reader("au_lname").ToString()
            txtPhone.Text = reader("phone").ToString()
            txtAddress.Text = reader("address").ToString()
            txtCity.Text = reader("city").ToString()
            txtState.Text = reader("state").ToString()
            txtZip.Text = reader("zip").ToString()
            chkContract.Checked = CType(reader("contract"), Boolean)
            reader.Close()
            lblResults.Text = ""

        Catch Err As Exception
            lblResults.Text = "Error getting author. "
            lblResults.Text &= Err.Message
        Finally
            con.Close()
        End Try
    End Sub

    Protected Sub cmdNew_Click(ByVal sender As Object, _
   ByVal e As System.EventArgs) Handles cmdNew.Click
        txtID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        chkContract.Checked = False

        lblResults.Text = "Click Insert New to add the completed record."
    End Sub

    Protected Sub cmdInsert_Click(ByVal sender As Object, _
   ByVal e As System.EventArgs) Handles cmdInsert.Click

        ' Perform user-defined checks.
        ' Alternatively, you could use RequiredFieldValidator controls.
        If txtID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            lblResults.Text = "Records require an ID, first name, and last name."
            Return
        End If

        ' Define ADO.NET objects.
        Dim insertSQL As String
        insertSQL = "INSERT INTO Authors ("
        insertSQL &= "au_id, au_fname, au_lname, "
        insertSQL &= "phone, address, city, state, zip, contract) "
        insertSQL &= "VALUES ("
        insertSQL &= "@au_id, @au_fname, @au_lname, "
        insertSQL &= "@phone, @address, @city, @state, @zip, @contract)"

        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(insertSQL, con)

        ' Add the parameters.
        cmd.Parameters.AddWithValue("@au_id", txtID.Text)
        cmd.Parameters.AddWithValue("@au_fname", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@au_Lname", txtLastName.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@city", txtCity.Text)
        cmd.Parameters.AddWithValue("@state", txtState.Text)
        cmd.Parameters.AddWithValue("@zip", txtZip.Text)
        cmd.Parameters.AddWithValue("@contract", chkContract.Checked)

        ' Try to open the database and execute the update.
        Dim added As Integer = 0
        Try
            con.Open()
            added = cmd.ExecuteNonQuery()
            lblResults.Text = added.ToString() & " record inserted."
        Catch Err As Exception
            lblResults.Text = "Error inserting record. "
            lblResults.Text &= Err.Message
        Finally
            con.Close()
        End Try

        ' If the insert succeeded, refresh the author list.
        If added > 0 Then
            FillAuthorList()
        End If
    End Sub


    Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        ' Define ADO.NET objects.
        Dim updateSQL As String
        updateSQL = "UPDATE Authors SET "
        updateSQL &= "au_fname=@au_fname, au_lname=@au_lname, "
        updateSQL &= "phone=@phone, address=@address, city=@city, state=@state, "
        updateSQL &= "zip=@zip, contract=@contract "
        updateSQL &= "WHERE au_id=@au_id_original"

        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(updateSQL, con)

        ' Add the parameters.
        cmd.Parameters.AddWithValue("@au_fname", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@au_lname", txtLastName.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@city", txtCity.Text)
        cmd.Parameters.AddWithValue("@state", txtState.Text)
        cmd.Parameters.AddWithValue("@zip", txtZip.Text)
        cmd.Parameters.AddWithValue("@contract", chkContract.Checked)
        cmd.Parameters.AddWithValue("@au_id_original", lstAuthor.SelectedItem.Value)

        ' Try to open database and execute the update.
        Dim updated As Integer
        Try
            con.Open()
            updated = cmd.ExecuteNonQuery()
            lblResults.Text = updated.ToString() & " record updated."
        Catch Err As Exception
            lblResults.Text = "Error updating author."
            lblResults.Text &= Err.Message
        Finally
            con.Close()
        End Try

        ' If the update succeeded, refresh the author list.
        If updated > 0 Then
            FillAuthorList()
        End If
    End Sub


    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        ' Define ADO.NET objects.
        Dim deleteSQL As String
        deleteSQL = "DELETE FROM Authors "
        deleteSQL &= "WHERE au_id=@au_id"

        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(deleteSQL, con)
        cmd.Parameters.AddWithValue("@au_id", lstAuthor.SelectedItem.Value)

        ' Try to open the database and delete the record.
        Dim deleted As Integer = 0
        Try
            con.Open()
            deleted = cmd.ExecuteNonQuery()
            lblResults.Text = "Record deleted."
        Catch err As Exception
            lblResults.Text = "Error deleting author."
            lblResults.Text &= err.Message
        Finally
            con.Close()
        End Try

        ' If the delete succeeded, refresh the author list.
        If deleted > 0 Then
            FillAuthorList()
        End If
    End Sub

End Class
