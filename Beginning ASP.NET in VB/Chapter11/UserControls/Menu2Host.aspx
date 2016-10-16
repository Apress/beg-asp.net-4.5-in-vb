<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Menu2Host.aspx.vb" Inherits="Menu2Host" %>
<%@ Register TagPrefix="apress" TagName="LinkMenu2" Src="LinkMenu2.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Menu Host</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>
                <td style="width: 100px">
                    <apress:LinkMenu2 id="Menu1" runat="server"  />
                </td>
                <td>
                    &nbsp;&nbsp;<asp:Label id="lblSelection" runat="server" EnableViewState="false"/><br />
                    &nbsp;&nbsp;<asp:Label id="lblClick" runat="server" EnableViewState="false"/>
                </td>
            </tr>
        </table>
        <br />
        &nbsp;
    </div>
    </form>
</body>
</html>

