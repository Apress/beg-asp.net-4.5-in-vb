<%@ Page Language="VB" AutoEventWireup="false" CodeFile="BasicGridView_SqlDataSource.aspx.vb" Inherits="BasicGridView_SqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
    
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
         ConnectionString="<%$ ConnectionStrings:Northwind %>"
         SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"></asp:SqlDataSource>
     </div>
    </form>
</body>
</html>
