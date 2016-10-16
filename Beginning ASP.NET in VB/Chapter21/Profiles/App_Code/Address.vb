
<Serializable()> _
Public Class Address

    Public Property Name() As String
    Public Property Street() As String
    Public Property City() As String
    Public Property ZipCode() As String
    Public Property State() As String
    Public Property Country() As String

    Public Sub New(ByVal name As String, ByVal street As String, _
    ByVal city As String, ByVal zipCode As String, ByVal state As String, _
    ByVal country As String)

        Me.Name = name
        Me.Street = street
        Me.City = city
        Me.ZipCode = zipCode
        Me.State = state
        Me.Country = country
    End Sub

    Public Sub New()
    End Sub

End Class

