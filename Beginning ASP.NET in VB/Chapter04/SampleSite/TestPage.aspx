<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TestPage.aspx.vb" Inherits="TestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 3px">

         <asp:Label ID="Label1" runat="server" 
           Text="Type something here:"  />
          <br />

          <asp:TextBox ID="TextBox1" runat="server" />
          <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
