Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration


Partial Class RecordEditor
    Inherits System.Web.UI.Page

    Private connectionString As String = _
  WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then
            ' Define the ADO.NET objects for selecting Products.
            Dim selectSQL As String = "SELECT ProductName, ProductID FROM Products"
            Dim con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(selectSQL, con)

            ' Open the connection.
            con.Open()

            ' Define the binding.
            lstProduct.DataSource = cmd.ExecuteReader()
            lstProduct.DataTextField = "ProductName"
            lstProduct.DataValueField = "ProductID"

            ' Activate the binding.
            lstProduct.DataBind()

            con.Close()

            ' Make sure nothing is currently selected.
            lstProduct.SelectedIndex = -1
        End If
    End Sub

    Protected Sub lstProduct_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProduct.SelectedIndexChanged

        ' Create a command for selecting the matching product record.
        Dim selectProduct As String = "SELECT ProductName, QuantityPerUnit, " & _
         "CategoryName FROM Products INNER JOIN Categories ON " & _
         "Categories.CategoryID=Products.CategoryID " & _
         "WHERE ProductID=@ProductID"

        ' Create the Connection and Command objects.
        Dim con As New SqlConnection(connectionString)
        Dim cmdProducts As New SqlCommand(selectProduct, con)
        cmdProducts.Parameters.AddWithValue("@ProductID", _
          lstProduct.SelectedItem.Value)

        ' Retrieve the information for the selected product.
        Using con
            con.Open()
            Dim reader As SqlDataReader = cmdProducts.ExecuteReader()
            reader.Read()

            ' Update the display.
            lblRecordInfo.Text = "<b>Product:</b> " & _
              reader("ProductName") & "<br />"
            lblRecordInfo.Text &= "<b>Quantity:</b> " & _
              reader("QuantityPerUnit") & "<br />"
            lblRecordInfo.Text &= "<b>Category:</b> " & reader("CategoryName")

            ' Store the corresponding CategoryName for future reference.
            Dim matchCategory As String = reader("CategoryName")

            ' Close the reader.
            reader.Close()

            ' Create a new Command for selecting categories.
            Dim selectCategory As String = "SELECT CategoryName, " & _
              "CategoryID FROM Categories"
            Dim cmdCategories As New SqlCommand(selectCategory, con)

            ' Retrieve the category information, and bind it.
            lstCategory.DataSource = cmdCategories.ExecuteReader()
            lstCategory.DataTextField = "CategoryName"
            lstCategory.DataValueField = "CategoryID"
            lstCategory.DataBind()

            ' Highlight the matching category in the list.
            lstCategory.Items.FindByText(matchCategory).Selected = True
        End Using

        pnlCategory.Visible = True
    End Sub

    Protected Sub cmdUpdate_Click(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles cmdUpdate.Click

        ' Define the Command.
        Dim updateCommand As String = "UPDATE Products " & _
         "SET CategoryID=@CategoryID WHERE ProductID=@ProductID"

        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(updateCommand, con)

        cmd.Parameters.AddWithValue("@CategoryID", lstCategory.SelectedItem.Value)
        cmd.Parameters.AddWithValue("@ProductID", lstProduct.SelectedItem.Value)

        ' Perform the update.
        Using con
            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
