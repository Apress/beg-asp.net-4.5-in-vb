
Partial Class TableContentPage
    Inherits System.Web.UI.Page

    Protected Sub cmdHide_Click(ByVal sender As Object, _
   ByVal e As System.EventArgs) Handles cmdHide.Click

        Dim master As TableMaster = CType(Me.Master, TableMaster)
        master.ShowNavigationControls = False

    End Sub

    Protected Sub cmdShow_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles cmdShow.Click

        Dim master As TableMaster = CType(Me.Master, TableMaster)
        master.ShowNavigationControls = True

    End Sub

End Class
