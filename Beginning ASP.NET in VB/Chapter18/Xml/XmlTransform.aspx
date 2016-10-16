<%@ Page Language="VB" AutoEventWireup="false" CodeFile="XmlTransform.aspx.vb" Inherits="XmlTransform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>The Transformed Contents of SuperProProductList.xml<br />
    </b>
        <br />    
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/App_Data/SuperProTransform.xml" TransformSource="~/App_Data/SuperProProductList.xsl"></asp:Xml>
    </div>
    </form>
</body>
</html>
