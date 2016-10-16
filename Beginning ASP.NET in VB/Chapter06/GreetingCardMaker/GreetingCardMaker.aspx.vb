Imports System.Drawing

Partial Class GreetingCardMaker
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
          Handles MyBase.Load
        If Not Me.IsPostBack Then

            ' Set color options.
            lstBackColor.Items.Add("White")
            lstBackColor.Items.Add("Red")
            lstBackColor.Items.Add("Green")
            lstBackColor.Items.Add("Blue")
            lstBackColor.Items.Add("Yellow")

            ' Set font options.
            lstFontName.Items.Add("Times New Roman")
            lstFontName.Items.Add("Arial")
            lstFontName.Items.Add("Verdana")
            lstFontName.Items.Add("Tahoma")

            ' Set border style options by adding a series of
            ' ListItem objects.
            ' Each item indicates the name of the option, and contains the
            '  corresponding integer in the Value property.
            lstBorder.Items.Add(New _
               ListItem(BorderStyle.None.ToString(), BorderStyle.None))
            lstBorder.Items.Add(New _
               ListItem(BorderStyle.Double.ToString(), BorderStyle.Double))
            lstBorder.Items.Add(New _
               ListItem(BorderStyle.Solid.ToString, BorderStyle.Solid))

            ' Select the first border option.
            lstBorder.SelectedIndex = 0

            ' Set the picture.
            imgDefault.ImageUrl = "defaultpic.png"
        End If
    End Sub

    Protected Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles cmdUpdate.Click

        ' Update the color.
        pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text)

        ' Update the font.
        lblGreeting.Font.Name = lstFontName.SelectedItem.Text

        If Val(txtFontSize.Text) > 0 Then
            lblGreeting.Font.Size = FontUnit.Point(Val(txtFontSize.Text))
        End If

        ' Update the border style.
        pnlCard.BorderStyle = Val(lstBorder.SelectedItem.Value)

        ' Update the picture.
        If chkPicture.Checked = True Then
            imgDefault.Visible = True
        Else
            imgDefault.Visible = False
        End If

        ' Set the text.
        lblGreeting.Text = txtGreeting.Text
    End Sub

End Class
