
Partial Class SessionStateExample
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) _
      Handles MyBase.Load

        If Me.IsPostBack = False Then
            ' Create Furniture objects.
            Dim Piece1 As New Furniture("Econo Sofa", _
                                        "Acme Inc.", 74.99)
            Dim Piece2 As New Furniture("Pioneer Table", _
                                        "Heritage Unit", 866.75)
            Dim Piece3 As New Furniture("Retro Cabinet", _
                                        "Sixties Ltd.", 300.11)

            ' Add objects to session state.
            Session("Furniture1") = Piece1
            Session("Furniture2") = Piece2
            Session("Furniture3") = Piece3

            ' Add rows to list control.
            lstItems.Items.Add(Piece1.Name)
            lstItems.Items.Add(Piece2.Name)
            lstItems.Items.Add(Piece3.Name)
        End If

        ' Display some basic information about the session.
        ' This is useful for testing configuration settings.
        lblSession.Text = "Session ID: " & Session.SessionID
        lblSession.Text &= "<br>Number of Objects: "
        lblSession.Text &= Session.Count.ToString()
        lblSession.Text &= "<br>Mode: " & Session.Mode.ToString()
        lblSession.Text &= "<br>Is Cookieless: "
        lblSession.Text &= Session.IsCookieless.ToString()
        lblSession.Text &= "<br>Is New: "
        lblSession.Text &= Session.IsNewSession.ToString()
        lblSession.Text &= "<br>Timeout (minutes): "
        lblSession.Text &= Session.Timeout.ToString()
    End Sub

    Protected Sub cmdMoreInfo_Click(ByVal sender As Object, _
    ByVal e As EventArgs) Handles cmdMoreInfo.Click

        If lstItems.SelectedIndex = -1 Then
            lblRecord.Text = "No item selected."
        Else
            ' Construct the right key name based on the index.
            Dim Key As String
            Key = "Furniture" & _
                  (lstItems.SelectedIndex + 1).ToString()

            ' Retrieve the Furniture object from session state.
            Dim Piece As Furniture = CType(Session(Key), Furniture)

            ' Display the information for this object.
            lblRecord.Text = "Name: " & Piece.Name
            lblRecord.Text &= "<br>Manufacturer: "
            lblRecord.Text &= Piece.Description
            lblRecord.Text &= "<br>Cost: " & Piece.Cost.ToString("c")
        End If
    End Sub

End Class
