
Partial Class TableTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
  Handles MyBase.Load
        ' Configure the table's appearance.
        ' This could also be performed in the .aspx file,
        ' or in the cmdCreate_Click event handler.
        tbl.BorderStyle = BorderStyle.Inset
        tbl.BorderWidth = Unit.Pixel(1)
    End Sub

    Protected Sub cmdCreate_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdCreate.Click

        ' Remove all the current rows and cells.
        ' This would not be necessary if you set EnableViewState = False.
        tbl.Controls.Clear()

        Dim row, col As Integer
        For row = 0 To Val(txtRows.Text - 1)

            ' Create a new TableRow object.
            Dim rowNew As New TableRow()

            ' Put the TableRow in the Table.
            tbl.Controls.Add(rowNew)

            For col = 0 To Val(txtCols.Text - 1)

                ' Create a new TableCell object.
                Dim cellNew As New TableCell()

                ' Create a new Label object.
                Dim lblNew As New Label()
                lblNew.Text = "Example Cell (" & row.ToString() & "," & col.ToString() & ")<br />"

                Dim imgNew As New Image()
                imgNew.ImageUrl = "cellpic.png"

                ' Put the label and picture in the cell.
                cellNew.Controls.Add(lblNew)
                cellNew.Controls.Add(imgNew)

                If chkBorder.Checked = True Then
                    cellNew.BorderStyle = BorderStyle.Inset
                    cellNew.BorderWidth = Unit.Pixel(1)
                End If
                ' Put the TableCell in the TableRow.
                rowNew.Controls.Add(cellNew)

            Next
        Next
    End Sub

End Class
