<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ValidationGroups.aspx.vb" Inherits="ValidationGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel Height="112px" ID="Panel1" runat="server" Width="392px" BorderWidth="2px" style="padding-right: 10px; padding-left: 10px; padding-bottom: 10px; padding-top: 10px" BackColor="#FFFFC0">
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="Group1"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="*Required" ID="RequiredFieldValidator1"
            runat="server" ValidationGroup="Group1" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Validate Group1" ValidationGroup="Group1"/></asp:Panel>
        
        &nbsp;<br />
        <asp:Panel Height="94px" ID="Panel2" runat="server" Width="392px" BorderWidth="2px" style="padding-right: 10px; padding-left: 10px; padding-bottom: 10px; padding-top: 10px" BackColor="#FFFFC0">
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="Group2"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="*Required" ID="RequiredFieldValidator2"
            runat="server" ValidationGroup="Group2" ControlToValidate="TextBox2"></asp:RequiredFieldValidator><br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Validate Group2" ValidationGroup="Group2"/></asp:Panel>
        
        <br /><br />
        
        <asp:Label EnableViewState="False" ID="lblInfo" runat="server"></asp:Label>
        <br /><br />
        Fill in one text box. You can now use the button in underneath to post back the 
		page. However, if you click the other button (the one next to the empty text 
		box), validation will fail for that group, and you won&#39;t be able to post back 
		the page.
		
    
    </div>
    </form>
</body>
</html>

