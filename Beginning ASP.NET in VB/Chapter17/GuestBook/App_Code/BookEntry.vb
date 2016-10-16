Public Class BookEntry
    Private _author As String
    Private _submitted As Date
    Private _message As String
 
    Public Property Author() As String
        Get
            Return _author
        End Get
        Set(ByVal Value As String)
            _author = Value
        End Set
    End Property

    Public Property Submitted() As Date
        Get
            Return _submitted
        End Get
        Set(ByVal Value As Date)
            _submitted = Value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return _message
        End Get
        Set(ByVal Value As String)
            _message = Value
        End Set
    End Property
End Class

