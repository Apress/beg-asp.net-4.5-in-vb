Imports System.IO

Partial Class UploadFile
    Inherits System.Web.UI.Page

    Private uploadDirectory As String

    Protected Sub cmdUpload_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles cmdUpload.Click

        ' Check that a file is actually being submitted.
        If FileInput.PostedFile.FileName = "" Then
            lblInfo.Text = "No file specified."
        Else
            ' Check the extension.
            Dim extension As String = _
              Path.GetExtension(FileInput.PostedFile.FileName)

            Select Case extension.ToLower()
                Case ".bmp", ".gif", ".jpg"
                    ' This is an allowed file type.
                Case Else
                    lblInfo.Text = "This file type is not allowed."
                    Return
            End Select

            ' Using this code, the saved file will retain its original
            ' file name, but be stored in the current server
            ' application directory.
            Dim serverFileName As String = _
              Path.GetFileName(FileInput.PostedFile.FileName)
            Dim fullUploadPath As String = _
              Path.Combine(uploadDirectory, serverFileName)

            Try
                FileInput.PostedFile.SaveAs(fullUploadPath)

                lblInfo.Text = "File " & serverFileName
                lblInfo.Text &= " uploaded successfully to "
                lblInfo.Text &= fullUploadPath
            Catch Err As Exception
                lblInfo.Text = err.Message
            End Try
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, "Uploads")
    End Sub
End Class
