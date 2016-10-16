Imports System.Drawing

Partial Class ErrorHandlingTest
    Inherits System.Web.UI.Page

    Protected Sub cmdCompute_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles cmdCompute.Click

        Try
            Dim A, B, Result As Decimal
            A = Decimal.Parse(txtA.Text)
            B = Decimal.Parse(txtB.Text)
            Result = A / B

            'Alternate approach:
            'Result = DivideNumbers(A, B)

            lblResult.Text = Result.ToString()
            lblResult.ForeColor = Color.Black
        Catch err As Exception
            lblResult.Text = "<b>Message:</b> " & err.Message & "<br /><br />"
            lblResult.Text &= "<b>Source:</b> " & err.Source & "<br /><br />"
            lblResult.Text &= "<b>Stack Trace:</b> " & err.StackTrace
            lblResult.ForeColor = Color.Red
        End Try

    End Sub

    Private Function DivideNumbers(ByVal number As Decimal, _
  ByVal divisor As Decimal) As Decimal
        If divisor = 0 Then
            Dim err As New DivideByZeroException( _
               "You supplied 0 for the divisor parameter. You must be stopped.")
            Throw err
        Else
            Return number / divisor
        End If
    End Function


End Class
