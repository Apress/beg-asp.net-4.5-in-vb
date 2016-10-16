
Partial Class AdRotatorTest
    Inherits System.Web.UI.Page

    Protected Sub Ads_AdCreated(ByVal sender As Object, _
    ByVal e As AdCreatedEventArgs) Handles Ads.AdCreated

        ' Synchronize the Hyperlink control.
        lnkBanner.NavigateUrl = e.NavigateUrl

        ' Syncrhonize the text of the link.
        lnkBanner.Text = "Click here for information about our sponsor: "
        lnkBanner.Text &= e.AlternateText()
    End Sub

End Class
