<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FormatHighPrices.aspx.vb" Inherits="FormatHighPrices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
            >
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="UnitPrice" HtmlEncode="false" HeaderText="Price" DataFormatString="{0:C}" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
