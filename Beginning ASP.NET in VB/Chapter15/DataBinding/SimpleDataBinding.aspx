<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SimpleDataBinding.aspx.vb" Inherits="SimpleDataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
      <asp:Label id="lblDynamic" runat="server" Font-Size="X-Large" >
      There were <%# TransactionCount %> transactions today.
      I see that you are using <%# Request.Browser.Browser %>.
      </asp:Label>

    </div>
    </form>
</body>
</html>
