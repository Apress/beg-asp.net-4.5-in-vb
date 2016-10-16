
Partial Class CrossPage1
    Inherits System.Web.UI.Page

    Public ReadOnly Property FullName() As String
        Get
            Return txtFirstName.Text & " " & txtLastName.Text
        End Get
    End Property

End Class
