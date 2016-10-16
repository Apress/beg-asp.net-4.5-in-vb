
Partial Class Footer
    Inherits System.Web.UI.UserControl

    Public Enum FooterFormat
        LongDate
        ShortTime
    End Enum

    Private _format As FooterFormat = FooterFormat.LongDate
    Public Property Format() As FooterFormat
        Get
            Return _format
        End Get
        Set(ByVal value As FooterFormat)
            _format = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Load

        lblFooter.Text = "This page was served at "

        If Format = FooterFormat.LongDate Then
            lblFooter.Text &= DateTime.Now.ToLongDateString()
        ElseIf Format = FooterFormat.ShortTime Then
            lblFooter.Text &= DateTime.Now.ToShortTimeString()
        End If
    End Sub

End Class


