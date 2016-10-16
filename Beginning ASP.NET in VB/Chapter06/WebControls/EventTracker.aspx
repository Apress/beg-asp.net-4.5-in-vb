<%@ Page Language="VB" AutoEventWireup="false" CodeFile="EventTracker.aspx.vb" Inherits="EventTracker" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
 "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Event Tracker</title>
  <style type="text/css">
      h1 
      {
          font-size: large;       
      }
  </style>
</head>
<body>
  <form runat="server">
  <div>
    <h1>Controls being monitored for change events:</h1>
    <asp:TextBox ID=txt runat="server" AutoPostBack="True"
      />
    <br /><br />
    <asp:CheckBox ID=chk runat="server" AutoPostBack="True"/>
    <br /><br />
    <asp:RadioButton ID=opt1 runat="server" GroupName="Sample"
         AutoPostBack="True" />
    <asp:RadioButton ID=opt2 runat="server" GroupName="Sample"
         AutoPostBack="True" />
    <br /><br />
    <h1>List of events:</h1>
    <asp:ListBox ID=lstEvents runat="server" Width="355px"
         Height="305px" /><br />
  </div>
  </form>
</body>
</html>
