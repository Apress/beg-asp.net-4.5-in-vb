Public Class Product

    Public Property Name() As String

    Public Event PriceChanged()

    Private _price As Decimal
    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            _price = value

            ' Fire the event to all listeners.
            RaiseEvent PriceChanged()
        End Set
    End Property

    Public Property ImageUrl() As String

    Public Function GetHtml() As String
        Dim htmlString As String
        htmlString = "<h1>" & Name & "</h1><br />"
        htmlString &= "<h3>Costs: " & Price.ToString() & "</h3><br />"
        htmlString &= "<img src='" & ImageUrl & "' />"
        Return htmlString
    End Function

    Public Sub New(ByVal name As String, ByVal price As Decimal)
        Me.Name = name
        Me.Price = price
    End Sub
    Public Sub New(ByVal name As String, ByVal price As Decimal, _
      ByVal imageUrl As String)
        Me.Name = name
        Me.Price = price
        Me.ImageUrl = imageUrl
    End Sub

End Class

