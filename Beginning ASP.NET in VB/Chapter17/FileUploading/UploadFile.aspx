<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UploadFile.aspx.vb" Inherits="UploadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Choose an image to upload:<br />
    <asp:FileUpload ID="FileInput" runat="server" Height="24px" Width="472px" />&nbsp;
        <asp:Button ID="cmdUpload" runat="server" Height="24px" 
            Text="Upload" Width="88px" /><br />
        <br />
        <asp:Label ID="lblInfo" runat="server" EnableViewState="False" Font-Bold="True"></asp:Label></div>
    </form>
</body>
</html>
