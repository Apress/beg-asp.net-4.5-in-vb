<%@ Page Language="VB" AutoEventWireup="false" CodeFile="XDocumentTest.aspx.vb" Inherits="XDocumentTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>XmlDocument Test</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="Box">
        <asp:Button ID="cmdCreateXml" runat="server" Text="Create XML" />
        <asp:Button ID="cmdReadXml" runat="server" Text="Read XML" Width="103px" />
        <asp:Button ID="cdmSearchXml" runat="server" Text="Search XML" Width="115px" />
    </div>
    <div>
        <br />
        <asp:Label ID="lblXml" runat="server" Text="" EnableViewState="false" ></asp:Label>&nbsp;
        <asp:GridView ID="gridResults"
            runat="server" EnableViewState="false" >
        </asp:GridView>
    </div>
    </form>
</body>
</html>