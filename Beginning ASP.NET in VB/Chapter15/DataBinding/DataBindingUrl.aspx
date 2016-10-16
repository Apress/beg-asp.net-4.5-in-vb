<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DataBindingUrl.aspx.vb" Inherits="DataBindingUrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label id="lblDynamic" runat="server"><%# URL %></asp:Label>
<br /><br />
<asp:CheckBox id="chkDynamic" Text="<%# URL %>" runat="server" />
<br /><br />
<asp:Hyperlink id="lnkDynamic" Text="Click here!" NavigateUrl="<%# URL %>" 
 runat="server" />
<br /><br />
<asp:Image id="imgDynamic" ImageUrl="<%# URL %>" runat="server" />

    </div>
    </form>
</body>
</html>
