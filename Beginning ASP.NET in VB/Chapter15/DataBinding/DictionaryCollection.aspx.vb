Imports System.Collections.Generic

Partial Class DictionaryCollection
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then
            ' Use integers to index each item. Each item is a string.
            Dim fruit As New Dictionary(Of Integer, String)()

            fruit.Add(1, "Kiwi")
            fruit.Add(2, "Pear")
            fruit.Add(3, "Mango")
            fruit.Add(4, "Blueberry")
            fruit.Add(5, "Apricot")
            fruit.Add(6, "Banana")
            fruit.Add(7, "Peach")
            fruit.Add(8, "Plum")

            ' Define the binding for the list controls.
            MyListBox.DataSource = fruit

            ' Choose what you want to display in the list...
            MyListBox.DataTextField = "Value"
            ' (and track behind the scenes).
            MyListBox.DataValueField = "Key"

            ' Activate the binding.
            Me.DataBind()
        End If
    End Sub


    Protected Sub MyListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyListBox.SelectedIndexChanged

        lblMessage.Text = "You picked: " & MyListBox.SelectedItem.Text
        lblMessage.Text &= " which has the key: " & MyListBox.SelectedItem.Value

    End Sub
End Class
