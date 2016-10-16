Imports System.Data.SqlClient

Partial Class ConnectionTester
    Inherits System.Web.UI.Page

    Protected Sub cmdConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        ' Define the ADO.NET Connection object.
        Dim connectionString As String = _
          "Data Source=localhost\SQLEXPRESS;Initial Catalog=Pubs;"

        If (optWindows.Checked) Then
            connectionString &= "Integrated Security=SSPI"
        Else
            connectionString &= "User ID=sa"
        End If

        Dim myConnection As New SqlConnection(connectionString)

        Try
            ' Try to open the connection.
            myConnection.Open()
            lblInfo.Text = "<b>Server Version:</b> " & myConnection.ServerVersion
            lblInfo.Text &= "<br /><b>Connection Is:</b> " & _
              myConnection.State.ToString()
        Catch Err As Exception
            ' Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. "
            lblInfo.Text &= Err.Message
        Finally
            ' Either way, make sure the connection is properly closed.
            ' (Even if the connection wasn't opened successfully,
            '  calling Close() won't cause an error.)
            myConnection.Close()
            lblInfo.Text &= "<br /><b>Now Connection Is:</b> "
            lblInfo.Text &= myConnection.State.ToString()
        End Try

    End Sub
End Class
