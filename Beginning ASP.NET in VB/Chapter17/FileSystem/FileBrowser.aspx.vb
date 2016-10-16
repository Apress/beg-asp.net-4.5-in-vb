Imports System.IO

Partial Class FileBrowser
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim startingDir As String = "c:\"
            lblCurrentDir.Text = startingDir
            ShowFilesIn(startingDir)
            ShowDirectoriesIn(startingDir)
        End If
    End Sub

    Private Sub ShowFilesIn(ByVal dir As String)
        lstFiles.Items.Clear()

        Try
            Dim dirInfo As New DirectoryInfo(dir)
            For Each fileItem As FileInfo In dirInfo.GetFiles()
                lstFiles.Items.Add(fileItem.Name)
            Next
        Catch err As Exception
            ' Ignore the error and leave the list box empty.
        End Try
    End Sub

    Private Sub ShowDirectoriesIn(ByVal dir As String)
        lblFileInfo.Text = ""
        lstDirs.Items.Clear()

        Try
            Dim dirInfo As New DirectoryInfo(dir)
            For Each dirItem As DirectoryInfo In dirInfo.GetDirectories()
                lstDirs.Items.Add(dirItem.Name)
            Next
        Catch err As Exception
            ' Ignore the error and leave the list box empty.
        End Try
    End Sub



    Protected Sub cmdBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdBrowse.Click
        ' Browse to the currently selected subdirectory.
        If lstDirs.SelectedIndex <> -1 Then
            Dim newDir As String = Path.Combine(lblCurrentDir.Text, _
  lstDirs.SelectedItem.Text)
            lblCurrentDir.Text = newDir
            ShowFilesIn(newDir)
            ShowDirectoriesIn(newDir)
        End If
    End Sub

    Protected Sub cmdParent_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdParent.Click
        ' Browse up to the current directory's parent.
        ' The Directory.GetParent method helps us out.
        Dim newDir As String
        If Directory.GetParent(lblCurrentDir.Text) Is Nothing Then
            ' This is the root directory; there are no more levels.
            Exit Sub
        Else
            newDir = Directory.GetParent(lblCurrentDir.Text).FullName
        End If

        lblCurrentDir.Text = newDir
        ShowFilesIn(newDir)
        ShowDirectoriesIn(newDir)
    End Sub

    Protected Sub cmdShowInfo_Click(ByVal sender As Object, _
      ByVal e As EventArgs) Handles cmdShowInfo.Click
        ' Show information for the currently selected file.
        If lstFiles.SelectedIndex <> -1 Then
            Dim fileName As String = Path.Combine(lblCurrentDir.Text, _
              lstFiles.SelectedItem.Text)

            Dim displayText As New StringBuilder()
            Try
                Dim selectedFile As New FileInfo(fileName)
                displayText.Append("<b>")
                displayText.Append(selectedFile.Name)
                displayText.Append("</b><br />Size: ")
                displayText.Append(selectedFile.Length)
                displayText.Append("<br />")
                displayText.Append("Created: ")
                displayText.Append(selectedFile.CreationTime.ToString())
                displayText.Append("<br />Last Accessed: ")
                displayText.Append(selectedFile.LastAccessTime.ToString())
            Catch err As Exception
                displayText.Append(err.Message)
            End Try

            lblFileInfo.Text = displayText.ToString()
        End If
    End Sub


End Class
