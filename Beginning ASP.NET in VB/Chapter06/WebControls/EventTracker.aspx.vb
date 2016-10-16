
Partial Class EventTracker
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
      Handles MyBase.Load
        Log("<< Page_Load >>")
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) _
      Handles MyBase.PreRender
        ' When the Page.PreRender event occurs it is too late
        ' to change the list.
        Log("Page_PreRender")
    End Sub

    Protected Sub CtrlChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles chk.CheckedChanged, opt1.CheckedChanged, opt2.CheckedChanged, _
              txt.TextChanged
        ' Find the control ID of the sender.
        ' This requires converting the Object type into a Control class.
        Dim ctrlName As String = CType(sender, Control).ID
        Log(ctrlName & " Changed")
    End Sub

    Private Sub Log(ByVal entry As String)
        lstEvents.Items.Add(entry)

        ' Select the last item to scroll the list so the most recent
        ' entries are visible.
        lstEvents.SelectedIndex = lstEvents.Items.Count - 1
    End Sub

End Class
