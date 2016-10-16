<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AdRotatorTest.aspx.vb" Inherits="AdRotatorTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:AdRotator id="Ads" runat="server" 
     Target="_blank" AdvertisementFile="~/MainAds.xml"  />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="lnkBanner" runat="server">HyperLink</asp:HyperLink></div>
    </form>
</body>
</html>
