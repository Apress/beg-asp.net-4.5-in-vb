
Partial Class TableMaster
    Inherits System.Web.UI.MasterPage

    Public Property ShowNavigationControls() As Boolean
        Set(ByVal Value As Boolean)
            Treeview1.Visible = Value
        End Set
        Get
            Return Treeview1.Visible
        End Get
    End Property

End Class

