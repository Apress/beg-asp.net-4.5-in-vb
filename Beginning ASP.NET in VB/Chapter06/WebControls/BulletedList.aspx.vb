
Partial Class BulletedList
    Inherits System.Web.UI.Page

    Protected Sub BulletedList1_Click(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.BulletedListEventArgs) Handles BulletedList1.Click

        Dim styleName As String = BulletedList1.Items(e.Index).Text
        Dim style As BulletStyle = CType(System.Enum.Parse(GetType(BulletStyle), styleName), BulletStyle)
        BulletedList1.BulletStyle = Style
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
        If Not Page.IsPostBack Then

            For Each style As String In System.Enum.GetNames(GetType(BulletStyle))
                BulletedList1.Items.Add(style)
            Next
        End If
    End Sub
End Class
