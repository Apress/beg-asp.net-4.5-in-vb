<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManualValidation.aspx.vb" Inherits="ManualValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Manual Validation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    A number (1 to 10):
	<asp:TextBox id="txtValidated" runat="server"></asp:TextBox>&nbsp;
	<asp:RangeValidator id="RangeValidator" runat="server" ErrorMessage="This Number Is Not In The Range" ControlToValidate="txtValidated" MaximumValue="10" MinimumValue="1" Type="Integer" EnableClientScript="False"></asp:RangeValidator><br />
	<br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
	<asp:TextBox id="txtNotValidated" runat="server"></asp:TextBox><br />
    <br />
	<br />
	<asp:Button id="cmdOK" runat="server" Text="OK" Width="36px"></asp:Button><br />
	<br />
	<asp:Label id="lblMessage" runat="server" EnableViewState="False"></asp:Label>
    </div>
    </form>
</body>
</html>