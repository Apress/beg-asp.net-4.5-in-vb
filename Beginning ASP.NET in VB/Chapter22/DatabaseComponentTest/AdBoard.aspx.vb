
Partial Class AdBoard
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Dim DB As New DatabaseComponent.DBUtil()

            lstCategories.DataSource = DB.GetCategories()
            lstCategories.DataTextField = "Name"
            lstCategories.DataValueField = "ID"
            lstCategories.DataBind()
            pnlNew.Visible = False
        End If
    End Sub

    Protected Sub cmdDisplay_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles cmdDisplay.Click

        Dim DB As New DatabaseComponent.DBUtil()

        gridItems.DataSource = DB.GetItems( _
          Val(lstCategories.SelectedItem.Value))
        gridItems.DataBind()
        pnlNew.Visible = True
    End Sub

    Protected Sub cmdAdd_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim DB As New DatabaseComponent.DBUtil()

        Try
            DB.AddItem(txtTitle.Text, txtDescription.Text, _
              Val(txtPrice.Text), Val(lstCategories.SelectedItem.Value))

            gridItems.DataSource = DB.GetItems( _
              Int32.Parse(lstCategories.SelectedItem.Value))
            gridItems.DataBind()
        Catch err As FormatException
            ' An error occurs if the user has entered an
            ' invalid price (non-numeric characters).
            ' In this case, take no action.
            ' Another option is to add a validator control
            ' for the price text box to prevent invalid input.
        End Try
    End Sub

End Class
