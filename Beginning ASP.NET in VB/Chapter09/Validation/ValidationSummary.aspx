<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ValidationSummary.aspx.vb" Inherits="ValidationSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Validation Summary</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>A number (1 to 10):
	<asp:textbox id="txtValidated" runat="server"></asp:textbox>&nbsp;
	<asp:rangevalidator id="RangeValidator" runat="server" Type="Integer" 
	MinimumValue="1" MaximumValue="10" ControlToValidate="txtValidated"
	Text="<img src='ErrorIcon.jpg' alt='Error' />"
	ErrorMessage="The First Number Is Not In The Range"></asp:rangevalidator><br />
	<br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
	<asp:textbox id="txtNotValidated" runat="server"></asp:textbox><br />
    </p>
    <p><br />
	<asp:button id="cmdOK" runat="server" Text="OK" Width="44px"></asp:button><br />
	<br />
	<asp:label id="lblMessage" runat="server" EnableViewState="False"></asp:label><br />
	<br />
	<asp:ValidationSummary id="ValidationSummary1" runat="server" ShowMessageBox="True"
     ForeColor="Red"></asp:ValidationSummary></p>
    </div>
    </form>
</body>
</html>
