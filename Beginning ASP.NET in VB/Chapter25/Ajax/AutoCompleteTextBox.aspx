<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AutoCompleteTextBox.aspx.vb" Inherits="AutoCompleteTextBox" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        Contact Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <ajaxToolkit:AutoCompleteExtender ID="autoComplete1" runat="server"
        TargetControlID="txtName" ServiceMethod="GetNames" MinimumPrefixLength="2">
        </ajaxToolkit:AutoCompleteExtender>
        <br /><br />Enter at least two letters (try "Li").
    </div>
    </form>
</body>
</html>
