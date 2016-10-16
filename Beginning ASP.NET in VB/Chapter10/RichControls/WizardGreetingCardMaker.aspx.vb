Imports System.Drawing

Partial Class WizardGreetingCardMaker
    Inherits System.Web.UI.Page

    Protected Sub Wizard1_FinishButtonClick(ByVal sender As Object, _
  ByVal e As WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick

        UpdateCard()
    End Sub

    Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IsPostBack = False Then

            ' Get the list of colors
            Dim ColorArray As String() = System.Enum.GetNames(GetType(System.Drawing.KnownColor))
            lstBackColor.DataSource = ColorArray
            lstBackColor.DataBind()

            lstForeColor.DataSource = ColorArray
            lstForeColor.DataBind()
            lstForeColor.SelectedIndex = 34
            lstBackColor.SelectedIndex = 163

            ' Get the list of available fonts, and add them to the font list.
            Dim Family As FontFamily
            Dim Fonts As New System.Drawing.Text.InstalledFontCollection()
            For Each Family In Fonts.Families
                lstFontName.Items.Add(Family.Name)
            Next

            ' Set border style options.
            Dim BorderStyleArray As String() = System.Enum.GetNames(GetType(BorderStyle))
            lstBorder.DataSource = BorderStyleArray
            lstBorder.DataBind()

            ' Select the first border option.
            lstBorder.SelectedIndex = 0

            ' Set the picture.
            imgDefault.ImageUrl = "defaultpic.png"

        End If

    End Sub

    Private Sub UpdateCard()

        ' Update the color.
        pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text)
        lblGreeting.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text)

        ' Update the font.
        lblGreeting.Font.Name = lstFontName.SelectedItem.Text
        If Val(txtFontSize.Text) > 0 Then
            lblGreeting.Font.Size = FontUnit.Point(Val(txtFontSize.Text))
        End If

        ' Update the border style.
        pnlCard.BorderStyle = System.ComponentModel.TypeDescriptor.GetConverter(GetType(BorderStyle)).ConvertFromString(lstBorder.SelectedItem.Text)

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
