Imports System.Xml
Imports System.Xml.Schema
Imports System.IO

Partial Class XmlValidation
    Inherits System.Web.UI.Page

    Protected Sub cmdValidate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdValidate.Click
        Dim filePath As String = Request.PhysicalApplicationPath & "\App_Data\"
        If optValid.Checked Then
            filePath &= "SuperProProductList.xml"	
        ElseIf optInvalidData.Checked Then
            filePath &= "InvalidData.xml"
        ElseIf optInvalidTag.Checked Then
            filePath &= "InvalidTag.xml"
        End If

        lblStatus.Text = ""

        ' Set the validation settings.
        Dim settings As New XmlReaderSettings()
        settings.Schemas.Add("http://www.SuperProProducts.com/SuperProProductList", _
          Request.PhysicalApplicationPath & "\App_Data\SuperProProductList.xsd")
        settings.ValidationType = ValidationType.Schema

        ' Attach the event handler.
        AddHandler settings.ValidationEventHandler, AddressOf ValidateHandler

        ' Open the XML file.
        Dim fs As New FileStream(filePath, FileMode.Open)

        ' Create the validating reader.
        Dim r As XmlReader = XmlReader.Create(fs, settings)

        ' Read through the document.
        Do While r.Read()
            ' Process document here.
            ' If an error is found, an exception will be thrown.
        Loop
        fs.Close()

        lblStatus.Text += "<br />Complete."
    End Sub

    Private Sub ValidateHandler(ByVal sender As Object, ByVal e As ValidationEventArgs)
        lblStatus.Text &= "Error: " & e.Message & "<br />"
    End Sub

End Class
