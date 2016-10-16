<%@ Page Language="VB" AutoEventWireup="false" CodeFile="IterativeVsDeclarative.aspx.vb" Inherits="IterativeVsDeclarative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Iterative Vs. Decalarative</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdForeach" runat="server" Text="Get Matches with foreach" />
        <asp:Button ID="cmdLinq" runat="server" Text="Get Matches with LINQ" /><br />
        <br />
        <asp:GridView ID="gridEmployees" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
