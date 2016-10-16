
Partial Class TestPage
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim number As Double

        ' Attempt to convert the text to a number.
        ' If it isn't, the Val() function returns 0.
        number = Val(TextBox1.Text)

        If number <> 0 Then
            number *= 2
            Label1.Text = "The doubled number is: " & number
        End If
    End Sub

End Class
