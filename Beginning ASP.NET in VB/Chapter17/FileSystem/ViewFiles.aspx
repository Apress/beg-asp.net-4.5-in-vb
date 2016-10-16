<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewFiles.aspx.vb" Inherits="ViewFiles" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ViewFiles</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <table style="border-right: 2px groove; border-top: 2px groove;
            border-left: 2px groove; width: 584px; border-bottom: 2px groove">
            <tr>
                <td style="padding-left: 15px; padding-bottom: 15px; padding-top: 15px">
                    <strong>Contents of the Files Directory</strong></td>
                <td style="padding-left: 15px; padding-bottom: 15px; padding-top: 15px">
                    <strong>Selected File Information</strong></td>
            </tr>
            <tr>
                <td style="vertical-align:top; padding-left: 15px; padding-right: 15px; padding-bottom: 15px; padding-top: 15px">
                    <asp:ListBox ID="lstFiles" runat="server" Height="272px" Font-Size="Smaller" AutoPostBack="True" ></asp:ListBox><br />
                    <br />
                    <asp:Button ID="cmdRefresh" runat="server" Text="Refresh" /></td>
                <td style="vertical-align:top; padding-left: 15px; padding-right: 15px; padding-bottom: 15px; padding-top: 15px">
                    <asp:Label ID="lblFileInfo" runat="server" Height="264px" Width="300px" BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px" Font-Size="Smaller"></asp:Label><br />
                    <br />
                    <asp:Button ID="cmdDelete" runat="server" Text="Delete" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
