<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PasswordRecovery.aspx.vb" Inherits="PasswordRecovery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
            Font-Size="0.8em" Height="144px" Width="344px" >
                        <InstructionTextStyle Font-Italic="True" ForeColor="Black"  />
            <SuccessTextStyle Font-Bold="True" ForeColor="#507CD1" />
            
           <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="35px" />
            <SubmitButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana"  ForeColor="#284E98" />
        </asp:PasswordRecovery>
    
    </div>
    </form>
</body>
</html>