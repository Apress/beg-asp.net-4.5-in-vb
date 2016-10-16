Imports System.IO
Imports System.Collections.Generic

Partial Class GuestBook
    Inherits System.Web.UI.Page

    Private guestBookName As String

    Protected Sub Page_Load(ByVal sender As Object, _
      ByVal e As EventArgs) Handles MyBase.Load
        guestBookName = Server.MapPath("~/App_Data/GuestBook")

        If Not Me.IsPostBack Then
            GuestBookList.DataSource = GetAllEntries()
            GuestBookList.DataBind()
        End If
    End Sub

    Protected Sub cmdSubmit_Click(ByVal sender As Object, _
      ByVal e As EventArgs) Handles cmdSubmit.Click
        ' Create a new BookEntry object.
        Dim newEntry As New BookEntry()
        newEntry.Author = txtName.Text
        newEntry.Submitted = DateTime.Now
        newEntry.Message = txtMessage.Text

        ' Let the SaveEntry procedure create the corresponding file.
        Try
            SaveEntry(newEntry)
        Catch err As Exception
            ' An error occurred. Notify the user and don't clear the 
            ' display.
            lblError.Text = err.Message & " File not saved."
            Exit Sub
        End Try

        ' Refresh the display.
        GuestBookList.DataSource = GetAllEntries()
        GuestBookList.DataBind()

        txtName.Text = ""
        txtMessage.Text = ""
    End Sub


    Private Function GetAllEntries() As List(Of BookEntry)
        ' Return a collection that contains BookEntry objects
        ' for each file in the GuestBook directory.
        ' This method relies on the GetEntryFromFile() method.
        Dim entries As New List(Of BookEntry)()

        Try
            Dim guestBookDir As New DirectoryInfo(guestBookName)

            For Each fileItem As FileInfo In guestBookDir.GetFiles()
                Try
                    entries.Add(GetEntryFromFile(fileItem))
                Catch
                    ' An error occurred when calling GetEntryFromFile().
                    ' Ignore this file because it can't be read.
                End Try
            Next
        Catch err As Exception
            ' An error occurred when calling GetFiles().
            ' Ignore this error and leave the entries collection empty.
        End Try

        Return entries
    End Function


    Private Function GetEntryFromFile(ByVal entryFile As FileInfo) _
      As BookEntry
        ' Turn the file information into a BookEntry object.
        Dim newEntry As New BookEntry()
        Dim r As StreamReader = entryFile.OpenText()
        newEntry.Author = r.ReadLine()
        newEntry.Submitted = DateTime.Parse(r.ReadLine())
        newEntry.Message = r.ReadToEnd()
        r.Close()

        Return newEntry
    End Function

    Private Sub SaveEntry(ByVal entry As BookEntry)
        ' Create a new file for this entry, with a file name that should
        ' be statistically unique.
        Dim random As New Random()
        Dim fileName As String = guestBookName & "\"
        fileName &= DateTime.Now.Ticks.ToString() & random.Next(100).ToString()
        Dim newFile As New FileInfo(fileName)
        Dim w As StreamWriter = newFile.CreateText()

        ' Write the information to the file.
        w.WriteLine(entry.Author)
        w.WriteLine(entry.Submitted.ToString())
        w.WriteLine(entry.Message)
        w.Flush()
        w.Close()
    End Sub

End Class
