<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GridViewSelect.aspx.vb" Inherits="GridViewSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Categories:<br />
        <asp:SqlDataSource ID="sourceCategories" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT * FROM Categories"></asp:SqlDataSource>
        <asp:GridView ID="gridCategories" runat="server" DataSourceID="sourceCategories" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CategoryID"
            >
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
        <br />
        Products in this category:<br />
        <asp:SqlDataSource ID="sourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products WHERE CategoryID=@CategoryID">
            <SelectParameters>
            <asp:ControlParameter Name="CategoryID" ControlID="gridCategories" PropertyName="SelectedDataKey.Value" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="gridProducts" runat="server" DataSourceID="sourceProducts" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4"
            >
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

