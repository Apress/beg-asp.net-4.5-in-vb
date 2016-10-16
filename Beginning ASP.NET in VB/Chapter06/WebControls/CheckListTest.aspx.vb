
Partial Class CheckListTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
  Handles MyBase.Load
        If Me.IsPostBack = False Then
            chklst.Items.Add("C")
            chklst.Items.Add("C++")
            chklst.Items.Add("C#")
            chklst.Items.Add("Visual Basic 6.0")
            chklst.Items.Add("VB.NET")
            chklst.Items.Add("Pascal")
        End If
    End Sub

    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
     Handles cmdOK.Click
        lblResult.Text = "You chose:<b>"

        Dim lstItem As ListItem
        For Each lstItem In chklst.Items
            If lstItem.Selected = True Then
                ' Add text to label.
                lblResult.Text &= "<br />" & lstItem.Text
            End If
        Next

        lblResult.Text &= "</b>"
    End Sub

End Class
