<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DictionaryCollection.aspx.vb" Inherits="DictionaryCollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="MyListBox" runat="server" AutoPostBack="True" Height="192px" OnSelectedIndexChanged="MyListBox_SelectedIndexChanged"
            Width="200px"></asp:ListBox><br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True"></asp:Label>
    </div>
   
    </form>
</body>
</html>
