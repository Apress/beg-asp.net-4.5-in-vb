<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ListDataBinding.aspx.vb" Inherits="ListDataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox id="MyListBox" runat="server" Width="197px" Height="193px"></asp:ListBox>
        <br /><br />
        <select id="MyHTMLSelect"  size="1"  runat="server"/>
		<br /><br />		
			<asp:DropDownList id="MyDropDownListBox" runat="server" Width="248px" Height="22px"></asp:DropDownList>
			<br /><br />
			<asp:CheckBoxList id="MyCheckBoxList"  runat="server" Width="201px" Height="157px"></asp:CheckBoxList>
			<br /><br />
			<asp:RadioButtonList id="MyRadioButtonList" runat="server" Width="249px" Height="158px"></asp:RadioButtonList>
        
     </div>
    </form>
</body>
</html>
