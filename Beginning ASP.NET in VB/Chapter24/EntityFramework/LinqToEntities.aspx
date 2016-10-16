<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LinqToEntities.aspx.vb" Inherits="LinqToEntities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        <asp:DropDownList ID="lstCategories" runat="server" AutoPostBack="true" 
          AppendDataBoundItems="true" >
          <asp:ListItem Text="(Select a Category)" Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="gridProducts" runat="server" CellPadding="4" GridLines="None" 
            Font-Size="X-Small" ForeColor="#333333" AutoGenerateColumns="True">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>

