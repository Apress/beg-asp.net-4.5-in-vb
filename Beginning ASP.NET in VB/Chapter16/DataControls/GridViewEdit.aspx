<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GridViewEdit.aspx.vb" Inherits="GridViewEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView2" runat="server" DataSourceID="sourceProducts"
  AutoGenerateColumns="False" DataKeyNames="ProductID" >           
    <Columns>
      <asp:BoundField DataField="ProductID" HeaderText="ID" ReadOnly="True" />
      <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
      <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
      <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource id="sourceProducts" runat="server" 
SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products" ConnectionString="<%$ ConnectionStrings:Northwind %>"
UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice WHERE ProductID=@ProductID"
></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>

