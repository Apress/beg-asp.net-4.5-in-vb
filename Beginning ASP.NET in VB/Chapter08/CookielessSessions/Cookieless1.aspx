<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Cookieless1.aspx.vb" Inherits="Cookieless1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table cellpadding="10">
            <tr>
                <td>
                    <asp:HyperLink ID="lnkRedirect" runat="server" NavigateUrl="Cookieless2.aspx">Link with Relative Path</asp:HyperLink>
                </td>
                <td>Hyperlink.NavigateUrl is set to <b>"Cookieless2.aspx"</b> in code.</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="cmdLink" runat="server" Text="Redirect with Relative Path"></asp:Button>
                </td>
                <td>The relative path uses<br><b>Response.Redirect("Cookieless2.aspx")</b></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="cmdLinkAbsolute" runat="server" Text="Redirect with Absolute Path"></asp:Button>
                </td>
                <td>The absolute path uses <b>Response.Redirect("http://localhost/.../Cookieless2.aspx)"</b></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

