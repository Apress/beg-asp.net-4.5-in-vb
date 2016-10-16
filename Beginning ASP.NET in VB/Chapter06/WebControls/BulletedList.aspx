<%@ Page Language="VB" AutoEventWireup="false" CodeFile="BulletedList.aspx.vb" Inherits="BulletedList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
 "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
 
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Bulleted List</title>
</head>
<body>
    <form id="Form1" runat="server">
    <div>
        Bullet styles:<br />
        <br />
        <asp:BulletedList BulletStyle="Numbered" DisplayMode="LinkButton" ID="BulletedList1"
            OnClick="BulletedList1_Click" runat="server">
        </asp:BulletedList>   
    </div>
    </form>
</body>
</html>