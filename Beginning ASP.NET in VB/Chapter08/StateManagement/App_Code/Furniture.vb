Public Class Furniture

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _cost As Double
    Public Property Cost() As Double
        Get
            Return _cost
        End Get
        Set(ByVal value As Double)
            _cost = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal description As String, _
    ByVal cost As Double)
        Me.Name = name
        Me.Description = description
        Me.Cost = cost
    End Sub

End Class
