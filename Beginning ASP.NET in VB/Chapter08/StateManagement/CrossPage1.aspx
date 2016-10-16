<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CrossPage1.aspx.vb" Inherits="CrossPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>CrossPage1</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" >
    <div>
        First Name:
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        Last Name:
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="cmdPost" 

                PostBackUrl="CrossPage2.aspx" Text="Cross-Page Postback" /><br />
        </div>
    </form>
</body>
</html>
