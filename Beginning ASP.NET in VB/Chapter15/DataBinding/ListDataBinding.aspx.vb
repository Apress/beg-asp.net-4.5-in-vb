Imports System.Collections.Generic

Partial Class ListDataBinding
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Create and fill the collection.
        Dim fruit As New List(Of String)()
        fruit.Add("Kiwi")
        fruit.Add("Pear")
        fruit.Add("Mango")
        fruit.Add("Blueberry")
        fruit.Add("Apricot")
        fruit.Add("Banana")
        fruit.Add("Peach")
        fruit.Add("Plum")

        ' Define the binding for the list controls.
        MyListBox.DataSource = fruit
        MyDropDownListBox.DataSource = fruit
        MyHTMLSelect.DataSource = fruit
        MyCheckBoxList.DataSource = fruit
        MyRadioButtonList.DataSource = fruit

        ' Activate the binding.
        Me.DataBind()

    End Sub
End Class
