<%@ Page Language="VB" AutoEventWireup="false" CodeFile="RecordEditor.aspx.vb" Inherits="RecordEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:DropDownList ID="lstProduct" runat="server" AutoPostBack="True" Width="280px" >
        </asp:DropDownList>
        <br />
        <br />
        <hr />
        <br />
        <table>
            <tr>
                <td style="width: 234px" valign="top">
                    <asp:Label ID="lblRecordInfo" runat="server"></asp:Label></td>
                <td style="width: 190px">
                    <asp:Panel ID="pnlCategory" runat="server" Visible="False">                    
                    <asp:ListBox ID="lstCategory" runat="server" Height="120px" Width="152px">
                    </asp:ListBox><br />
                    <br />
                    <asp:Button ID="cmdUpdate" runat="server" Text="Update"  />
                    </asp:Panel>
                    </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
