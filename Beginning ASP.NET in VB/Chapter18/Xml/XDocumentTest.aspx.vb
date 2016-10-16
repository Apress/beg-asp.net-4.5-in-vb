Imports System.IO
Imports System.Xml

Partial Class XDocumentTest
    Inherits System.Web.UI.Page

    Private file As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        file = Path.Combine(Request.PhysicalApplicationPath, "App_Data\SuperProProductList_NoNamespace.xml")
    End Sub

    Protected Sub cmdCreateXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cmdCreateXml.Click

        ' Build the XML content in memory.
        Dim doc As New XDocument( _
          New XDeclaration("1.0", Nothing, "yes"), _
          New XComment("Created with the XDocument class."), _
          New XElement("SuperProProductList", _
            New XElement("Product", _
              New XAttribute("ID", 1), _
              New XAttribute("Name", "Chair"), _
              New XElement("Price", "49.33")), _
            New XElement("Product", _
              New XAttribute("ID", 2), _
              New XAttribute("Name", "Car"), _
              New XElement("Price", "43399.55")), _
            New XElement("Product", _
              New XAttribute("ID", 3), _
              New XAttribute("Name", "Fresh Fruit Basket"), _
              New XElement("Price", "49.99"))))

        ' Save the document.
        doc.Save(file)

    End Sub

    Protected Sub cmdReadXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cmdReadXml.Click

        ' Load the document.
        Dim doc As XDocument = XDocument.Load(file)

        ' Loop through all the nodes, and create the list of Product objects .
        Dim products As List(Of Product) = New List(Of Product)()

        For Each element As XElement In doc.Element("SuperProProductList").Elements("Product")
            Dim newProduct As New Product()
            newProduct.ID = element.Attribute("ID")
            newProduct.Name = element.Attribute("Name")
            newProduct.Price = element.Element("Price")

            products.Add(newProduct)
        Next

        ' Display the results.
        gridResults.DataSource = products
        gridResults.DataBind()

        ' Display the retrieved document.
        gridResults.DataSource = Products
        gridResults.DataBind()
    End Sub

    Protected Sub cdmSearchXml_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles cdmSearchXml.Click

        Dim doc As XDocument = XDocument.Load(file)

        ' Find the matches.
        Dim results = doc.Descendants("Price")

        ' Display the results.
        lblXml.Text = "<b>Found " & results.Count.ToString() & " Matches "
        lblXml.Text &= " for the Price tag: </b><br /><br />"
        For Each result As XElement In results
            lblXml.Text += result.Value & "<br />"
        Next

    End Sub

End Class
