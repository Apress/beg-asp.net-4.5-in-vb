
Partial Class FooterHost
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles Me.Load

        If optLong.Checked Then
            Footer1.Format = Footer.FooterFormat.LongDate
        ElseIf optShort.Checked Then
            Footer1.Format = Footer.FooterFormat.ShortTime
        Else
            ' The default value in the Footer class will apply.
        End If
    End Sub

End Class
