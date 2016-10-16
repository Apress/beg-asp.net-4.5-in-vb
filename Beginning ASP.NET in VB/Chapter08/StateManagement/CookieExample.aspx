<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CookieExample.aspx.vb" Inherits="CookieExample" Trace="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div style="border-right: 2px solid; padding-right: 30px; border-top: 2px solid; padding-left: 30px; font-weight: bold; font-size: 140%; padding-bottom: 30px; border-left: 2px solid; padding-top: 30px; border-bottom: 2px solid; font-family: Verdana; background-color: #FFFFD9">
        <asp:Label ID="lblWelcome" runat="server" EnableViewState="False" ></asp:Label>
      </div>
      <br />
      Name:
      <asp:TextBox ID="txtName" runat="server" Width="178px"></asp:TextBox>
      <asp:Button ID="cmdStore" runat="server" Text="Create Cookie" />
    </div>
    </form>
</body>
</html>