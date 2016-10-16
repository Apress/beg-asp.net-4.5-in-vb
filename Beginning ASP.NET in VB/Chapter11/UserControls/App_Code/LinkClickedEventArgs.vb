Public Class LinkClickedEventArgs
    Inherits System.EventArgs

    Public Property Url() As String
    Public Property Cancel() As Boolean

    Public Sub New(ByVal url As String)
        Me.Url = url
    End Sub

End Class

