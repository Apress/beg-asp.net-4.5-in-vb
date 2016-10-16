<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CurrencyConverter.aspx.vb" Inherits="CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>
        <div style="border-right: thin ridge; padding-right: 20px; border-top: thin ridge;
            padding-left: 20px; padding-bottom: 20px; border-left: thin ridge; width: 531px;
            padding-top: 20px; border-bottom: thin ridge; font-family: Verdana; background-color: #FFFFE8">
            Convert: &nbsp;
            <input ID="US" runat="server" style="width: 102px" type="text" />
            &nbsp; U.S. dollars
            to &nbsp;
            <select ID="Currency" runat="server" />
            <br />
            <br />
            <input ID="Convert" runat="server" type="submit"
                value="OK" />
            <input ID="ShowGraph" runat="server" type="submit"
                value="Show Graph" />
            <br />
            <br />
            <img ID="Graph" alt="Currency Graph" src="" runat="server" />
            <br />
            <br />
            <p ID="Result" runat="server" style="font-weight: bold"></p>
        </div>    
    </div>
    </form>
</body>
</html>
