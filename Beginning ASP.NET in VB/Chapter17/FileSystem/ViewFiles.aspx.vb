Imports System.IO

Partial Class ViewFiles
    Inherits System.Web.UI.Page

    Private filesDirectory As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        filesDirectory = Path.Combine(Request.PhysicalApplicationPath, "Files")

        If Not Me.IsPostBack Then
            CreateFileList()
        End If
    End Sub

    Private Sub CreateFileList()
        ' Retrieve the list of files, and display it in the page.
        ' This code also disables the delete button, ensuring the
        ' user must view the file information before deleting it.
        Try
            Dim fileList() As String = Directory.GetFiles(filesDirectory)
            lstFiles.DataSource = fileList
            lstFiles.DataBind()
            lblFileInfo.Text = ""
        Catch err As Exception
            lblFileInfo.Text = err.Message
        End Try
        cmdDelete.Enabled = False
    End Sub

    Protected Sub cmdRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdRefresh.Click
        CreateFileList()
    End Sub

    Protected Sub lstFiles_SelectedIndexChanged(ByVal sender As Object, _
      ByVal e As EventArgs) Handles lstFiles.SelectedIndexChanged
        Try
            ' Display the selected file information.
            ' This control has AutoPostback = True.
            Dim fileName As String = lstFiles.SelectedItem.Text
            Dim sb As New System.Text.StringBuilder
            sb.Append("<b>")
            sb.Append(fileName)
            sb.Append("</b><br /><br />")
            sb.Append("Created: ")
            sb.Append(File.GetCreationTime(fileName).ToString())
            sb.Append("<br />Last Accessed: ")
            sb.Append(File.GetLastAccessTime(fileName).ToString())
            sb.Append("<br />")

            ' Show attribute information. GetAttributes can return a combination
            ' of enumerated values, so you need to evaluate it with the
            ' And keyword.
            Dim Attr As FileAttributes = File.GetAttributes(fileName)
            If (Attr And FileAttributes.Hidden) = FileAttributes.Hidden Then
                sb.Append("This is a hidden file.<br />")
            End If
            If (Attr And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
                sb.Append("This is a read-only file.<br />")
                cmdDelete.Enabled = False
            Else
                cmdDelete.Enabled = True
            End If

            lblFileInfo.Text = sb.ToString()
        Catch err As Exception
            lblFileInfo.Text = err.Message
            cmdDelete.Enabled = False
        End Try
    End Sub

    Protected Sub cmdDelete_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdDelete.Click
        Try
            File.Delete(lstFiles.SelectedItem.Text)
        Catch err As Exception
            lblFileInfo.Text = err.Message
        End Try

        CreateFileList()
    End Sub

End Class
