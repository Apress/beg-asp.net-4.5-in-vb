<%@ Page Language="VB" AutoEventWireup="false" CodeFile="HtmlEncodeTest.aspx.vb" Inherits="HtmlEncodeTest" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>    
        <h1>Properly encoded:</h1> 
        <p ID="ctrl2" runat="server"/>
        <br /><hr /><br />
        <h1>Incorrectly encoded:</h1> 
        <p ID="ctrl1" runat="server"/>
    </div>
    </form>
</body>
</html>
