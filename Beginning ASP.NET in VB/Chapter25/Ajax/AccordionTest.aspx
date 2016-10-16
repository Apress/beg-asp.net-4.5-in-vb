<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AccordionTest.aspx.vb" Inherits="AccordionTest" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <ajaxToolkit:Accordion ID="Accordion1" runat="server"
  HeaderCssClass="accordionHeader"
  HeaderSelectedCssClass="accordionHeaderSelected"
  ContentCssClass="accordionContent">

  <Panes>
    <ajaxToolkit:AccordionPane runat="server">
      <Header>Colors</Header>
      <Content>
        Choose a background color:<br />
        <asp:DropDownList id="lstBackColor" runat="server"
         Width="194px" AutoPostBack="True">
        </asp:DropDownList>
        <br /><br />
        Choose a foreground (text) color:<br />
        <asp:DropDownList id="lstForeColor" runat="server"
         Height="22px" Width="194px" AutoPostBack="True" >
        </asp:DropDownList>
      </Content>
    </ajaxToolkit:AccordionPane>

    <ajaxToolkit:AccordionPane runat="server">
      <Header>Text</Header>
      <Content>
        Choose a font name:<br />
        <asp:DropDownList id="lstFontName" runat="server"
         Height="22px" Width="194px" AutoPostBack="True">
        </asp:DropDownList>
        <br /><br />
        Specify a font size:<br />
        <asp:TextBox id="txtFontSize" runat="server" 
         AutoPostBack="True">
        </asp:TextBox>
        <br /><br />
        Enter the greeting text below:<br />
        <asp:TextBox id="txtGreeting" runat="server"
         Height="85px" Width="240px" TextMode="MultiLine"
         AutoPostBack="True">
        </asp:TextBox>
      </Content>
    </ajaxToolkit:AccordionPane>

    <ajaxToolkit:AccordionPane>
      <Header>Other</Header>
      <Content>
        Choose a border style:<br />
        <asp:RadioButtonList id="lstBorder" runat="server"
         Height="59px" Width="177px" Font-Size="X-Small"
         AutoPostBack="True" RepeatColumns="2">
        </asp:RadioButtonList>
        <br /><br />
        <asp:CheckBox id="chkPicture" runat="server"
         Text="Add the Default Picture" AutoPostBack="True">
        </asp:CheckBox>
        </Content>
    </ajaxToolkit:AccordionPane>
  </Panes>            
</ajaxToolkit:Accordion>

</div>
    </form>
</body>
</html>

