Imports System.Data.SqlClient
Imports System.Web.Configuration
Imports System.Collections.Generic

Partial Class AutoCompleteTextBox
    Inherits System.Web.UI.Page

    <System.Web.Services.WebMethod()> _
<System.Web.Script.Services.ScriptMethod()> _
Public Shared Function GetNames(ByVal prefixText As String, _
  ByVal count As Integer) As List(Of String)
        Dim names As List(Of String)

        ' Check if the list is in the cache.
        If HttpContext.Current.Cache("NameList") Is Nothing Then
            ' If not, regenerate the list. The ADO.NET code for this part
            ' isn't shown (but you can see it in the downloadable examples
            ' for this chapter.
            names = GetNameListFromDB()

            ' Store the name list in the cache for sixty minutes.
            HttpContext.Current.Cache.Insert("NameList", names, Nothing, _
              DateTime.Now.AddMinutes(60), TimeSpan.Zero)
        Else
            ' Get the name list out of the cache.
            names = CType(HttpContext.Current.Cache("NameList"), List(Of String))
        End If

        Dim index As Integer = -1
        For i As Integer = 0 To names.Count - 1
            ' Check if this is a suitable match.
            If names(i).StartsWith(prefixText, StringComparison.InvariantCultureIgnoreCase) Then
                index = i
                Exit For
            End If
        Next

        ' Give up if there isn't a match.
        If index = -1 Then Return New List(Of String)()

        Dim wordList As New List(Of String)()
        For i As Integer = index To (index + count - 1)
            ' Stop if the end of the list is reached.
            If i >= names.Count Then Exit For

            ' Stop if the names stop matching.
            If Not names(i).StartsWith(prefixText, StringComparison.InvariantCultureIgnoreCase) Then Exit For

            wordList.Add(names(i))
        Next

        Return wordList
    End Function

    Private Shared Function GetNameListFromDB() As List(Of String)
        Dim connectionString As String = WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("SELECT ContactName FROM Customers ORDER BY ContactName", con)

        Dim names As New List(Of String)()

        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Do While reader.Read()
                names.Add(reader("ContactName"))
            Loop
            reader.Close()

            Return names

        Finally
            con.Close()
        End Try
    End Function
End Class
